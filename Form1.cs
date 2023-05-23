using AppATM.Interfaces;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace AppATM
{
    public partial class Form1 : Form, IATMActions
    {
        #region Global variables
        //Credentials for email.
        const string EUser = "sarahi.reyessrv@outlook.com";
        const string Password = "UTAU-0401";
        enum ATMstatus
        {
            Home,
            Deposit,
            Withdrawal,
            W1, W2, W3, W4,
            Query,
            AddBills,
            SubtractBills
        }
        ATMstatus Actualstatus;
        readonly string database = "server=HP-SARAHI\\SARAHIDB; database=atmDB; integrated security=true";
        private int BalanceActualUser;
        private string NameActualUser;
        private int txtamount;
        int totalAmount;
        readonly Timer timer;
        User user;
        int bancknote100;
        int bancknote200;
        int bancknote500;
        private int newBalance;
        #endregion
        public Form1()
        {
            InitializeComponent();
            WelcomePanel.Visible = true;
            OptionsPanel.Visible = false;
            DepositPanel.Visible = false;
            SelectedBillPanel.Visible = false;
            NotFoundsPanel.Visible = false;
            WithdrawalPanel.Visible = false;
            withdrawalSuccessfullPanel.Visible = false;
            ErrorAmountPanel.Visible = false;
            ErrorBillsPanel.Visible = false;
            ErrorHomePanel.Visible = false;
            ErrorDispensedPanel.Visible = false;
            QueryPanel.Visible = false;
            insufficientBalancePanel.Visible = false;
            timer = new Timer();
            timer.Interval = 5000; // 5 seconds
            timer.Tick += BtnCancel_Click;
        }

        #region Method´s IATMActions
        public void Deposit(int amount)
        {
            bancknote100 = (int)nud100.Value;
            bancknote200 = (int)nud200.Value;
            bancknote500 = (int)nud500.Value;
            totalAmount = (bancknote100 * 100) + (bancknote200 * 200) + (bancknote500 * 500);

            if (totalAmount == txtamount)
            {
                using (SqlConnection connection = new SqlConnection(database))
                {
                    connection.Open();

                    string updateQuery = "UPDATE [Money] SET Quantity = Quantity + @Quantity WHERE Denomination = @Denomination";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", bancknote100);
                        command.Parameters.AddWithValue("@Denomination", 100);
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Quantity", bancknote200);
                        command.Parameters.AddWithValue("@Denomination", 200);
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Quantity", bancknote500);
                        command.Parameters.AddWithValue("@Denomination", 500);
                        command.ExecuteNonQuery();
                    }
                }

                newBalance = BalanceActualUser + txtamount;
                UpdateBalanceInDatabase(newBalance);
                UpdateUserBalance();
                //UpdateBalanceInDatabase(newBalance);
                Console.Beep();
                DepositSuccesfulLabel.Visible = true;
                BtnEnter.Enabled = false;
                timer.Start();
            }
            else
            {
                Console.Beep();
                SelectedBillPanel.Visible = false;
                ErrorBillsPanel.Visible = true;
                BtnEnter.Enabled = false;
                timer.Start();
                return;
            }
        }
        public void Withdrawal(int WAmount)
        {
            // Verificar si el monto a retirar es válido
            if (WAmount <= 0)
            {
                Console.Beep();
                WithdrawalPanel.Visible = false;
                ErrorAmountPanel.Visible = true;
                BtnEnter.Enabled = false;
                timer.Start();
                return;
            }

            // Verificar si el usuario tiene suficiente saldo para el retiro
            else if (WAmount > BalanceActualUser)
            {
                Console.Beep();
                WithdrawalPanel.Visible = false;
                insufficientBalancePanel.Visible = true;
                BtnEnter.Enabled = false;
                timer.Start();
                return;
            }
            // Verificar si hay suficiente dinero en el cajero
            else if (!HasAnyFunds())
            {
                Console.Beep();
                WithdrawalPanel.Visible = false;
                NotFoundsPanel.Visible = true;
                BtnEnter.Enabled = false;
                timer.Start();
                //Information to send an email.
                string De = "sarahi.reyessrv@outlook.com";
                string Para = "sarahi.reyessrv@outlook.com";
                string Asunto = "Insufficient funds alert at the ATM";
                string Mensaje = "It has been confirmed that the ATM does not have available bills for withdrawals.\r\nPlease request an administrator to refill the bills in the ATM's database.\r\nThank you.";
                string Error = "";
                StringBuilder MensajeBuiler = new StringBuilder();
                MensajeBuiler.Append(Mensaje);
                SendEmail(MensajeBuiler, DateTime.Now, De, Para, Asunto, out Error);
                return;
            }
            // Verificar si el monto a retirar se puede dispensar con los billetes disponibles
            else if (!CanDispenseAmount(WAmount))
            {
                Console.Beep();
                WithdrawalPanel.Visible = false;
                ErrorDispensedPanel.Visible = true;
                BtnEnter.Enabled = false;
                timer.Start();
                return;
            }
            // Realizar el retiro
            DispenseAmount(WAmount);

            // Actualizar el saldo del usuario en la base de datos
            newBalance = BalanceActualUser - WAmount;
            UpdateBalanceInDatabase(newBalance);
            UpdateUserBalance();
            CreateTransactionFile(DateTime.Now, newBalance);

            Console.Beep();
            WithdrawalPanel.Visible = false;
            withdrawalSuccessfullPanel.Visible = true;
            BtnEnter.Enabled = false;
            timer.Start();
        }
        #endregion


        #region Method´s
        private bool HasAnyFunds()
        {
            int[] denominations = new int[] { 500, 200, 100 };

            foreach (int denomination in denominations)
            {
                int availableQuantity = GetAvailableQuantity(denomination);

                if (availableQuantity > 0)
                {
                    return true;
                }
            }
            return false;
        }
        private int GetAvailableQuantity(int denomination)
        {
            int quantity = 0;

            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                string query = "SELECT Quantity FROM [Money] WHERE Denomination = @Denomination";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Denomination", denomination);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        quantity = (int)result;
                    }
                }
            }

            return quantity;
        }
        private bool CanDispenseAmount(int withdrawalAmount)
        {
            int remainingAmount = withdrawalAmount;
            int[] denominations = new int[] { 500, 200, 100 };

            foreach (int denomination in denominations)
            {
                int availableQuantity = GetAvailableQuantity(denomination);
                int requiredQuantity = remainingAmount / denomination;

                if (requiredQuantity > availableQuantity)
                {
                    remainingAmount -= availableQuantity * denomination;
                }
                else
                {
                    remainingAmount %= denomination;
                }
            }

            return remainingAmount == 0;
        }
        private void DispenseAmount(int withdrawalAmount)
        {
            int remainingAmount = withdrawalAmount;
            int[] denominations = new int[] { 500, 200, 100 };

            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                foreach (int denomination in denominations)
                {
                    int availableQuantity = GetAvailableQuantity(denomination);
                    int requiredQuantity = remainingAmount / denomination;
                    int dispensedQuantity = Math.Min(requiredQuantity, availableQuantity);

                    if (dispensedQuantity > 0)
                    {
                        string updateQuery = "UPDATE [Money] SET Quantity = Quantity - @Quantity WHERE Denomination = @Denomination";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Quantity", dispensedQuantity);
                            command.Parameters.AddWithValue("@Denomination", denomination);
                            command.ExecuteNonQuery();
                        }

                        remainingAmount -= dispensedQuantity * denomination;
                    }
                }
            }
        }
        private void UpdateBalanceInDatabase(int newBalance)
        {

            using (SqlConnection connection = new SqlConnection(database))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al conectar a la base de datos.");
                    return;
                }

                string query = "UPDATE [user] SET Balance = @Balance WHERE id = @Id AND name = @Name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Balance", newBalance);
                    command.Parameters.AddWithValue("@Id", user.ID);
                    command.Parameters.AddWithValue("@Name", NameActualUser);
                    command.ExecuteNonQuery();
                }
            }
        }
        private int GetBalanceFromDatabase()
        {
            int balance = 0;

            using (SqlConnection connection = new SqlConnection(database))
            {
                connection.Open();

                string query = "SELECT Balance FROM [user] WHERE id = @Id AND name = @Name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", user.ID);
                    command.Parameters.AddWithValue("@Name", NameActualUser);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        balance = (int)result;
                    }
                }
            }

            return balance;
        }
        private void UpdateUserBalance()
        {
            BalanceActualUser = GetBalanceFromDatabase();
        }
        private void CreateTransactionFile(DateTime dateTime, int currentBalance)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Transaction" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            string filePath = Path.Combine(desktopPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("User: " + NameActualUser);
                writer.WriteLine("Date: " + dateTime.ToString("yyyy-MM-dd"));
                writer.WriteLine("Time: " + dateTime.ToString("hh:mm:ss tt"));
                writer.WriteLine("Withdrawal transaction");
                writer.WriteLine("Withdrawal Amount: " + String.Format("{0:C}", txtBoxWithdrawalAmount.Text) + " MXN");
                writer.WriteLine("Current balance: " + String.Format("{0:C2}", currentBalance) + " MXN");
                writer.WriteLine("Thank you for your preference!");
            }
        }
        public static void SendEmail(StringBuilder Mensaje, DateTime FechaEnvio, string De, string Para, string Asunto, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("This email was sent on {0:dd/MM/yyyy} at {0:HH:mm:ss} Hrs: \n\n", FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.office365.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(EUser, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Email successfully sent";
            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        #endregion

        #region Home Options
        private void BtnVerify_Click(object sender, EventArgs e)
        {
            user = new User();
            if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxN.Text) || string.IsNullOrWhiteSpace(textBoxNIP.Text))
            {
                MessageBox.Show("Please enter ID, name, and NIP.");
                textBoxID.Clear();
                textBoxNIP.Clear();
                textBoxN.Clear();
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(database))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error connecting to the database.");
                        return;
                    }
                    int id = Convert.ToInt32(textBoxID.Text);
                    user.ID = id;
                    string name = textBoxN.Text;
                    user.Name = name;


                    string query = "SELECT * FROM [user] WHERE id = @Id AND name = @Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid credentials. Please try again.");
                                textBoxID.Clear();
                                textBoxNIP.Clear();
                                textBoxN.Clear();
                                return;
                            }
                            else
                            {
                                string storedNIP = reader["NIP"].ToString();
                                if (storedNIP != textBoxNIP.Text)
                                {
                                    MessageBox.Show("Invalid credentials. Please try again.");
                                    textBoxID.Clear();
                                    textBoxNIP.Clear();
                                    textBoxN.Clear();
                                    return;
                                }

                                BalanceActualUser = Convert.ToInt32(reader["Balance"]);
                                NameActualUser = reader["Name"].ToString();
                                Console.Beep();
                                WelcomePanel.Visible = false;
                                OptionsPanel.Visible = true;
                                UserLabel.Text = user.Name.ToUpper();
                                Actualstatus = ATMstatus.Home;
                            }
                        }
                    }
                }
            }
        }
        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            OptionsPanel.Visible = false;
            Console.Beep();
            SelectedBillPanel.Visible = false;
            DepositPanel.Visible = true;
            Actualstatus = ATMstatus.Deposit;
        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            user.NIP = null;
            user.ID = 0;
            user.Name = null;
            textBoxID.Clear();
            textBoxNIP.Clear();
            textBoxN.Clear();
            Console.Beep();
            WelcomePanel.Visible = true;
        }
        private void BtnWithdrawal_Click(object sender, EventArgs e)
        {
            OptionsPanel.Visible = false;
            DepositPanel.Visible = false;
            SelectedBillPanel.Visible = false;
            Console.Beep();
            withdrawalSuccessfullPanel.Visible = false;
            WithdrawalPanel.Visible = true;
            Actualstatus = ATMstatus.Withdrawal;
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Actualstatus = ATMstatus.Query;
            int currentBalance = GetBalanceFromDatabase();
            QueryPanel.Visible = true;
            QueryLabel.Text = (String.Format("{0:C2}", currentBalance) + " MXN");

        }
        #endregion

        #region Enter - Clear - Cancel Buttons
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            switch (Actualstatus)
            {
                case ATMstatus.Deposit:

                    if (!DepositPanel.Visible)
                    {
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtBoxDepositAmount.Text, out int amount) && amount % 100 == 0 && amount > 99)
                        {
                            DepositPanel.Visible = false;
                            Console.Beep();
                            SelectedBillPanel.Visible = true;
                            Actualstatus = ATMstatus.AddBills;
                            txtamount = amount;
                        }
                        else
                        {
                            DepositPanel.Visible = false;
                            ErrorAmountPanel.Visible = true;
                            BtnEnter.Enabled = false;
                            timer.Start();
                            return;
                        }
                    }
                    break;
                case ATMstatus.AddBills:
                    ((IATMActions)this).Deposit(txtamount);
                    break;
                case ATMstatus.Withdrawal:
                    if (!WithdrawalPanel.Visible)
                    {
                        return;
                    }
                    else
                    {
                        if (int.TryParse(txtBoxWithdrawalAmount.Text, out int WAmount) && WAmount % 100 == 0 && WAmount > 99)
                        {
                            WithdrawalPanel.Visible = false;
                            Console.Beep();
                            BtnEnter.Enabled = false;
                            txtamount = WAmount;
                            ((IATMActions)this).Withdrawal(txtamount);
                        }
                        else
                        {
                            WithdrawalPanel.Visible = false;
                            ErrorAmountPanel.Visible = true;
                            BtnEnter.Enabled = false;
                            timer.Start();
                            return;
                        }
                    }
                    break;
                case ATMstatus.Query:
                    BtnEnter.Enabled = false;
                    BtnCancel_Click(sender, e);
                    break;
                case ATMstatus.Home:
                    ErrorHomePanel.Visible = true;
                    UpdateUserBalance();
                    Console.Beep();
                    BtnEnter.Enabled = false;
                    timer.Start();
                    break;
                default:
                    break;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Actualstatus = ATMstatus.Home;
            UpdateUserBalance();
            OptionsPanel.Visible = true;
            ErrorAmountPanel.Visible = false;
            ErrorHomePanel.Visible = false;
            ErrorBillsPanel.Visible = false;
            ErrorDispensedPanel.Visible = false;
            DepositPanel.Visible = false;
            QueryPanel.Visible = false;
            insufficientBalancePanel.Visible = false;
            withdrawalSuccessfullPanel.Visible = false;
            WithdrawalPanel.Visible = false;
            SelectedBillPanel.Visible = false;
            NotFoundsPanel.Visible = false;
            txtBoxDepositAmount.Text = string.Empty;
            txtBoxWithdrawalAmount.Text = string.Empty;
            BtnEnter.Enabled = true;
            txtamount = 0;
            bancknote100 = 0;
            bancknote200 = 0;
            bancknote500 = 0;
            totalAmount = 0;
            newBalance = 0;
            nud100.Value = 0;
            nud200.Value = 0;
            nud500.Value = 0;
            DepositSuccesfulLabel.Visible = false;
            Timer1_Tick(sender, e);
            Console.Beep();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (DepositPanel.Visible)
            {
                if (!string.IsNullOrEmpty(txtBoxDepositAmount.Text))
                {
                    txtBoxDepositAmount.Text = txtBoxDepositAmount.Text.Remove(txtBoxDepositAmount.Text.Length - 1);
                }
            }
            else if (WithdrawalPanel.Visible)
            {
                if (!string.IsNullOrEmpty(txtBoxWithdrawalAmount.Text))
                {
                    txtBoxWithdrawalAmount.Text = txtBoxWithdrawalAmount.Text.Remove(txtBoxWithdrawalAmount.Text.Length - 1);
                }
            }
        }
        #endregion

        #region Other events
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            if (DepositPanel.Visible || WithdrawalPanel.Visible)
            {
                txtBoxDepositAmount.Text += number;
                txtBoxWithdrawalAmount.Text += number;
            }
            else
            {
                return;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
        }
        private void AuthorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        #endregion
    }
}
