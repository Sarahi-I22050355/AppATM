using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppATM.Interfaces
{
    internal interface IATMActions
    {
        void Deposit(int amount);
        void Withdrawal(int WAmount);
    }
}
