using AppATM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AppATM
{
    internal class User : Person
    {
        private string nip;
        private int balance;

        public string NIP
        {
            get { return nip; }
            set { nip = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public User() : base()
        {
            nip = string.Empty;
            balance = 0;
        }
        public User(string nip, int balance, int id, string name): base(name,id)
        {
            this.nip = nip;
            this.balance = balance;

        }
    }
}
