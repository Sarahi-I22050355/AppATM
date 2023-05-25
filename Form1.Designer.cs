namespace AppATM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Screen = new System.Windows.Forms.Label();
            this.ATM = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn00 = new System.Windows.Forms.Button();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.AuthorLabel = new System.Windows.Forms.LinkLabel();
            this.BtnVerify = new System.Windows.Forms.Button();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WithdrawalPanel = new System.Windows.Forms.Panel();
            this.txtBoxWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnWithdrawal = new System.Windows.Forms.Button();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.DepositPanel = new System.Windows.Forms.Panel();
            this.txtBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DepositSuccessfullLabel = new System.Windows.Forms.Label();
            this.SelectedBillPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nud500 = new System.Windows.Forms.NumericUpDown();
            this.nud200 = new System.Windows.Forms.NumericUpDown();
            this.nud100 = new System.Windows.Forms.NumericUpDown();
            this.withdrawalSuccessfullPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.QueryPanel = new System.Windows.Forms.Panel();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ErrorAmountPanel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.ErrorBillsPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.ErrorHomePanel = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.insufficientBalancePanel = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.NotFoundsPanel = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.ErrorDispensedPanel = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.WelcomePanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.WithdrawalPanel.SuspendLayout();
            this.DepositPanel.SuspendLayout();
            this.SelectedBillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud100)).BeginInit();
            this.withdrawalSuccessfullPanel.SuspendLayout();
            this.QueryPanel.SuspendLayout();
            this.ErrorAmountPanel.SuspendLayout();
            this.ErrorBillsPanel.SuspendLayout();
            this.ErrorHomePanel.SuspendLayout();
            this.insufficientBalancePanel.SuspendLayout();
            this.NotFoundsPanel.SuspendLayout();
            this.ErrorDispensedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.AutoSize = true;
            this.Screen.Location = new System.Drawing.Point(120, 29);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(0, 13);
            this.Screen.TabIndex = 0;
            // 
            // ATM
            // 
            this.ATM.AutoSize = true;
            this.ATM.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATM.ForeColor = System.Drawing.Color.Silver;
            this.ATM.Location = new System.Drawing.Point(626, 9);
            this.ATM.Name = "ATM";
            this.ATM.Size = new System.Drawing.Size(133, 65);
            this.ATM.TabIndex = 0;
            this.ATM.Text = "ATM";
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(236, 312);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 50);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(302, 311);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(50, 50);
            this.Btn2.TabIndex = 0;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(369, 311);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(50, 50);
            this.Btn3.TabIndex = 0;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(234, 367);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(50, 50);
            this.Btn4.TabIndex = 0;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(302, 367);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(50, 50);
            this.Btn5.TabIndex = 0;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(369, 367);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(50, 50);
            this.Btn6.TabIndex = 0;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(234, 423);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(50, 50);
            this.Btn7.TabIndex = 0;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(302, 423);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(50, 50);
            this.Btn8.TabIndex = 0;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(369, 423);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(50, 50);
            this.Btn9.TabIndex = 0;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(234, 479);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(50, 50);
            this.Btn0.TabIndex = 0;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // Btn00
            // 
            this.Btn00.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn00.Location = new System.Drawing.Point(302, 479);
            this.Btn00.Name = "Btn00";
            this.Btn00.Size = new System.Drawing.Size(117, 50);
            this.Btn00.TabIndex = 0;
            this.Btn00.Text = "00";
            this.Btn00.UseVisualStyleBackColor = true;
            this.Btn00.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.WelcomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WelcomePanel.BackgroundImage")));
            this.WelcomePanel.Controls.Add(this.AuthorLabel);
            this.WelcomePanel.Controls.Add(this.BtnVerify);
            this.WelcomePanel.Controls.Add(this.textBoxNIP);
            this.WelcomePanel.Controls.Add(this.textBoxN);
            this.WelcomePanel.Controls.Add(this.textBoxID);
            this.WelcomePanel.Controls.Add(this.label5);
            this.WelcomePanel.Controls.Add(this.label4);
            this.WelcomePanel.Controls.Add(this.label3);
            this.WelcomePanel.Controls.Add(this.label1);
            this.WelcomePanel.Controls.Add(this.label2);
            this.WelcomePanel.Location = new System.Drawing.Point(-2, -1);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(799, 542);
            this.WelcomePanel.TabIndex = 13;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AuthorLabel.Location = new System.Drawing.Point(12, 487);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(114, 17);
            this.AuthorLabel.TabIndex = 9;
            this.AuthorLabel.TabStop = true;
            this.AuthorLabel.Text = "Software Engineer";
            this.AuthorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLabel_LinkClicked);
            // 
            // BtnVerify
            // 
            this.BtnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerify.Location = new System.Drawing.Point(301, 425);
            this.BtnVerify.Name = "BtnVerify";
            this.BtnVerify.Size = new System.Drawing.Size(234, 51);
            this.BtnVerify.TabIndex = 8;
            this.BtnVerify.Text = "Verify User";
            this.BtnVerify.UseVisualStyleBackColor = true;
            this.BtnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIP.Location = new System.Drawing.Point(368, 345);
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(106, 40);
            this.textBoxNIP.TabIndex = 7;
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.Location = new System.Drawing.Point(368, 296);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(254, 40);
            this.textBoxN.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(368, 242);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(254, 40);
            this.textBoxID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(302, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(283, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter your user credentials.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 86);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to the ATM";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancel.Location = new System.Drawing.Point(438, 311);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(117, 51);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Yellow;
            this.BtnClear.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.Olive;
            this.BtnClear.Location = new System.Drawing.Point(438, 366);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 51);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEnter.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnEnter.Location = new System.Drawing.Point(438, 422);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(117, 51);
            this.BtnEnter.TabIndex = 0;
            this.BtnEnter.Text = "ENTER";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.Blue;
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OptionsPanel.Controls.Add(this.label10);
            this.OptionsPanel.Controls.Add(this.label9);
            this.OptionsPanel.Controls.Add(this.label8);
            this.OptionsPanel.Controls.Add(this.label7);
            this.OptionsPanel.Controls.Add(this.UserLabel);
            this.OptionsPanel.Controls.Add(this.label6);
            this.OptionsPanel.Location = new System.Drawing.Point(190, 9);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(411, 301);
            this.OptionsPanel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Query";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Withdrawal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Deposit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 30.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(136, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 144);
            this.label7.TabIndex = 2;
            this.label7.Text = "What would \r\nyou like \r\nto do?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(117, 24);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 34);
            this.UserLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hello,";
            // 
            // WithdrawalPanel
            // 
            this.WithdrawalPanel.BackColor = System.Drawing.Color.Blue;
            this.WithdrawalPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WithdrawalPanel.Controls.Add(this.txtBoxWithdrawalAmount);
            this.WithdrawalPanel.Controls.Add(this.label12);
            this.WithdrawalPanel.Location = new System.Drawing.Point(190, 9);
            this.WithdrawalPanel.Name = "WithdrawalPanel";
            this.WithdrawalPanel.Size = new System.Drawing.Size(411, 301);
            this.WithdrawalPanel.TabIndex = 6;
            // 
            // txtBoxWithdrawalAmount
            // 
            this.txtBoxWithdrawalAmount.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBoxWithdrawalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWithdrawalAmount.Location = new System.Drawing.Point(77, 150);
            this.txtBoxWithdrawalAmount.Name = "txtBoxWithdrawalAmount";
            this.txtBoxWithdrawalAmount.Size = new System.Drawing.Size(256, 57);
            this.txtBoxWithdrawalAmount.TabIndex = 1;
            this.txtBoxWithdrawalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(395, 74);
            this.label12.TabIndex = 0;
            this.label12.Text = "What amount would you\r\n like to withdraw?";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeposit.Location = new System.Drawing.Point(72, 98);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(112, 47);
            this.BtnDeposit.TabIndex = 15;
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnWithdrawal
            // 
            this.BtnWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWithdrawal.Location = new System.Drawing.Point(72, 169);
            this.BtnWithdrawal.Name = "BtnWithdrawal";
            this.BtnWithdrawal.Size = new System.Drawing.Size(112, 47);
            this.BtnWithdrawal.TabIndex = 16;
            this.BtnWithdrawal.UseVisualStyleBackColor = false;
            this.BtnWithdrawal.Click += new System.EventHandler(this.BtnWithdrawal_Click);
            // 
            // BtnQuery
            // 
            this.BtnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnQuery.Location = new System.Drawing.Point(72, 240);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(112, 47);
            this.BtnQuery.TabIndex = 17;
            this.BtnQuery.UseVisualStyleBackColor = false;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // DepositPanel
            // 
            this.DepositPanel.BackColor = System.Drawing.Color.Blue;
            this.DepositPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DepositPanel.Controls.Add(this.txtBoxDepositAmount);
            this.DepositPanel.Controls.Add(this.label11);
            this.DepositPanel.Location = new System.Drawing.Point(190, 9);
            this.DepositPanel.Name = "DepositPanel";
            this.DepositPanel.Size = new System.Drawing.Size(411, 301);
            this.DepositPanel.TabIndex = 6;
            // 
            // txtBoxDepositAmount
            // 
            this.txtBoxDepositAmount.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBoxDepositAmount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDepositAmount.Location = new System.Drawing.Point(75, 153);
            this.txtBoxDepositAmount.Name = "txtBoxDepositAmount";
            this.txtBoxDepositAmount.Size = new System.Drawing.Size(258, 57);
            this.txtBoxDepositAmount.TabIndex = 4;
            this.txtBoxDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(398, 82);
            this.label11.TabIndex = 3;
            this.label11.Text = "How much would \r\nyou like to deposit?";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DepositSuccessfullLabel
            // 
            this.DepositSuccessfullLabel.AutoSize = true;
            this.DepositSuccessfullLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.DepositSuccessfullLabel.ForeColor = System.Drawing.Color.White;
            this.DepositSuccessfullLabel.Location = new System.Drawing.Point(65, 250);
            this.DepositSuccessfullLabel.Name = "DepositSuccessfullLabel";
            this.DepositSuccessfullLabel.Size = new System.Drawing.Size(280, 22);
            this.DepositSuccessfullLabel.TabIndex = 5;
            this.DepositSuccessfullLabel.Text = "The deposit was successful.";
            this.DepositSuccessfullLabel.Visible = false;
            // 
            // SelectedBillPanel
            // 
            this.SelectedBillPanel.BackColor = System.Drawing.Color.Blue;
            this.SelectedBillPanel.Controls.Add(this.DepositSuccessfullLabel);
            this.SelectedBillPanel.Controls.Add(this.label16);
            this.SelectedBillPanel.Controls.Add(this.label15);
            this.SelectedBillPanel.Controls.Add(this.label14);
            this.SelectedBillPanel.Controls.Add(this.label13);
            this.SelectedBillPanel.Controls.Add(this.nud500);
            this.SelectedBillPanel.Controls.Add(this.nud200);
            this.SelectedBillPanel.Controls.Add(this.nud100);
            this.SelectedBillPanel.Location = new System.Drawing.Point(190, 9);
            this.SelectedBillPanel.Name = "SelectedBillPanel";
            this.SelectedBillPanel.Size = new System.Drawing.Size(411, 301);
            this.SelectedBillPanel.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 14.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(395, 69);
            this.label16.TabIndex = 6;
            this.label16.Text = "Please select the bills \r\nto deposit without exceeding\r\nthe amount you previously" +
    " selected.";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(156, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 28);
            this.label15.TabIndex = 5;
            this.label15.Text = "$500.00 MXN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(156, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "$200.00 MXN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(156, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 28);
            this.label13.TabIndex = 3;
            this.label13.Text = "$100.00 MXN";
            // 
            // nud500
            // 
            this.nud500.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud500.Location = new System.Drawing.Point(83, 201);
            this.nud500.Name = "nud500";
            this.nud500.Size = new System.Drawing.Size(49, 33);
            this.nud500.TabIndex = 2;
            // 
            // nud200
            // 
            this.nud200.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud200.Location = new System.Drawing.Point(83, 154);
            this.nud200.Name = "nud200";
            this.nud200.Size = new System.Drawing.Size(49, 33);
            this.nud200.TabIndex = 1;
            // 
            // nud100
            // 
            this.nud100.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud100.Location = new System.Drawing.Point(83, 112);
            this.nud100.Name = "nud100";
            this.nud100.Size = new System.Drawing.Size(49, 33);
            this.nud100.TabIndex = 0;
            // 
            // withdrawalSuccessfullPanel
            // 
            this.withdrawalSuccessfullPanel.BackColor = System.Drawing.Color.Blue;
            this.withdrawalSuccessfullPanel.Controls.Add(this.label17);
            this.withdrawalSuccessfullPanel.ForeColor = System.Drawing.Color.White;
            this.withdrawalSuccessfullPanel.Location = new System.Drawing.Point(190, 9);
            this.withdrawalSuccessfullPanel.Name = "withdrawalSuccessfullPanel";
            this.withdrawalSuccessfullPanel.Size = new System.Drawing.Size(411, 301);
            this.withdrawalSuccessfullPanel.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label17.Location = new System.Drawing.Point(62, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(303, 246);
            this.label17.TabIndex = 0;
            this.label17.Text = "The withdrawal \r\nwas successful.\r\nPlease review \r\nyour ticket.\r\n\r\nThank you.";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // QueryPanel
            // 
            this.QueryPanel.BackColor = System.Drawing.Color.Blue;
            this.QueryPanel.Controls.Add(this.QueryLabel);
            this.QueryPanel.Controls.Add(this.label18);
            this.QueryPanel.ForeColor = System.Drawing.Color.White;
            this.QueryPanel.Location = new System.Drawing.Point(190, 9);
            this.QueryPanel.Name = "QueryPanel";
            this.QueryPanel.Size = new System.Drawing.Size(411, 301);
            this.QueryPanel.TabIndex = 6;
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Font = new System.Drawing.Font("Consolas", 23.25F);
            this.QueryLabel.ForeColor = System.Drawing.Color.White;
            this.QueryLabel.Location = new System.Drawing.Point(94, 126);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(0, 37);
            this.QueryLabel.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(7, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(399, 180);
            this.label18.TabIndex = 0;
            this.label18.Text = "Your current balance is:\r\n\r\n\r\n\r\nPress ENTER to continue";
            // 
            // ErrorAmountPanel
            // 
            this.ErrorAmountPanel.BackColor = System.Drawing.Color.Blue;
            this.ErrorAmountPanel.Controls.Add(this.label19);
            this.ErrorAmountPanel.ForeColor = System.Drawing.Color.White;
            this.ErrorAmountPanel.Location = new System.Drawing.Point(190, 9);
            this.ErrorAmountPanel.Name = "ErrorAmountPanel";
            this.ErrorAmountPanel.Size = new System.Drawing.Size(411, 301);
            this.ErrorAmountPanel.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 23.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label19.Location = new System.Drawing.Point(45, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(323, 259);
            this.label19.TabIndex = 0;
            this.label19.Text = "The amount \r\nmust be a \r\nround number,\r\n for example, \r\n100, 200, etc.\r\n\r\nPlease " +
    "try again.";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorBillsPanel
            // 
            this.ErrorBillsPanel.BackColor = System.Drawing.Color.Blue;
            this.ErrorBillsPanel.Controls.Add(this.label20);
            this.ErrorBillsPanel.ForeColor = System.Drawing.Color.White;
            this.ErrorBillsPanel.Location = new System.Drawing.Point(190, 9);
            this.ErrorBillsPanel.Name = "ErrorBillsPanel";
            this.ErrorBillsPanel.Size = new System.Drawing.Size(411, 301);
            this.ErrorBillsPanel.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label20.Location = new System.Drawing.Point(27, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(359, 185);
            this.label20.TabIndex = 0;
            this.label20.Text = "The selected bills \r\ndo not match \r\nthe entered amount.\r\n\r\nPlease try again.";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorHomePanel
            // 
            this.ErrorHomePanel.BackColor = System.Drawing.Color.Blue;
            this.ErrorHomePanel.Controls.Add(this.label21);
            this.ErrorHomePanel.ForeColor = System.Drawing.Color.White;
            this.ErrorHomePanel.Location = new System.Drawing.Point(190, 9);
            this.ErrorHomePanel.Name = "ErrorHomePanel";
            this.ErrorHomePanel.Size = new System.Drawing.Size(411, 301);
            this.ErrorHomePanel.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label21.Location = new System.Drawing.Point(20, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(379, 86);
            this.label21.TabIndex = 0;
            this.label21.Text = "Please select an \r\noption to perform.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insufficientBalancePanel
            // 
            this.insufficientBalancePanel.BackColor = System.Drawing.Color.Blue;
            this.insufficientBalancePanel.Controls.Add(this.label22);
            this.insufficientBalancePanel.ForeColor = System.Drawing.Color.White;
            this.insufficientBalancePanel.Location = new System.Drawing.Point(190, 9);
            this.insufficientBalancePanel.Name = "insufficientBalancePanel";
            this.insufficientBalancePanel.Size = new System.Drawing.Size(411, 301);
            this.insufficientBalancePanel.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label22.Location = new System.Drawing.Point(44, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(335, 135);
            this.label22.TabIndex = 0;
            this.label22.Text = "Insufficient \r\nbalance \r\nfor withdrawal.";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotFoundsPanel
            // 
            this.NotFoundsPanel.BackColor = System.Drawing.Color.Blue;
            this.NotFoundsPanel.Controls.Add(this.label23);
            this.NotFoundsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NotFoundsPanel.Location = new System.Drawing.Point(190, 9);
            this.NotFoundsPanel.Name = "NotFoundsPanel";
            this.NotFoundsPanel.Size = new System.Drawing.Size(411, 301);
            this.NotFoundsPanel.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 29F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(7, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(398, 92);
            this.label23.TabIndex = 0;
            this.label23.Text = "No funds available\r\n in the ATM";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorDispensedPanel
            // 
            this.ErrorDispensedPanel.BackColor = System.Drawing.Color.Blue;
            this.ErrorDispensedPanel.Controls.Add(this.label24);
            this.ErrorDispensedPanel.ForeColor = System.Drawing.Color.White;
            this.ErrorDispensedPanel.Location = new System.Drawing.Point(190, 9);
            this.ErrorDispensedPanel.Name = "ErrorDispensedPanel";
            this.ErrorDispensedPanel.Size = new System.Drawing.Size(411, 301);
            this.ErrorDispensedPanel.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label24.Location = new System.Drawing.Point(16, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(374, 128);
            this.label24.TabIndex = 0;
            this.label24.Text = "It is not possible \r\nto dispense the \r\nrequested amount \r\nwith the available bill" +
    "s";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogOut.Font = new System.Drawing.Font("Consolas", 15.25F);
            this.BtnLogOut.Location = new System.Drawing.Point(72, 27);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(112, 47);
            this.BtnLogOut.TabIndex = 21;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(796, 534);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.BtnWithdrawal);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.Btn00);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.ATM);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.ErrorAmountPanel);
            this.Controls.Add(this.QueryPanel);
            this.Controls.Add(this.ErrorBillsPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.WithdrawalPanel);
            this.Controls.Add(this.SelectedBillPanel);
            this.Controls.Add(this.NotFoundsPanel);
            this.Controls.Add(this.ErrorDispensedPanel);
            this.Controls.Add(this.withdrawalSuccessfullPanel);
            this.Controls.Add(this.DepositPanel);
            this.Controls.Add(this.ErrorHomePanel);
            this.Controls.Add(this.insufficientBalancePanel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AppATM";
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.WithdrawalPanel.ResumeLayout(false);
            this.WithdrawalPanel.PerformLayout();
            this.DepositPanel.ResumeLayout(false);
            this.DepositPanel.PerformLayout();
            this.SelectedBillPanel.ResumeLayout(false);
            this.SelectedBillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud100)).EndInit();
            this.withdrawalSuccessfullPanel.ResumeLayout(false);
            this.withdrawalSuccessfullPanel.PerformLayout();
            this.QueryPanel.ResumeLayout(false);
            this.QueryPanel.PerformLayout();
            this.ErrorAmountPanel.ResumeLayout(false);
            this.ErrorAmountPanel.PerformLayout();
            this.ErrorBillsPanel.ResumeLayout(false);
            this.ErrorBillsPanel.PerformLayout();
            this.ErrorHomePanel.ResumeLayout(false);
            this.ErrorHomePanel.PerformLayout();
            this.insufficientBalancePanel.ResumeLayout(false);
            this.insufficientBalancePanel.PerformLayout();
            this.NotFoundsPanel.ResumeLayout(false);
            this.NotFoundsPanel.PerformLayout();
            this.ErrorDispensedPanel.ResumeLayout(false);
            this.ErrorDispensedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Label ATM;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn00;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVerify;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdrawal;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel DepositPanel;
        private System.Windows.Forms.TextBox txtBoxDepositAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DepositSuccessfullLabel;
        private System.Windows.Forms.Panel SelectedBillPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nud500;
        private System.Windows.Forms.NumericUpDown nud200;
        private System.Windows.Forms.NumericUpDown nud100;
        private System.Windows.Forms.Panel WithdrawalPanel;
        private System.Windows.Forms.TextBox txtBoxWithdrawalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel withdrawalSuccessfullPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel QueryPanel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel ErrorAmountPanel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel ErrorBillsPanel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel ErrorHomePanel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel insufficientBalancePanel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel NotFoundsPanel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel ErrorDispensedPanel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.LinkLabel AuthorLabel;
    }

}

