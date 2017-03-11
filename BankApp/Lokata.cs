using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Lokata:Account
    {
        private static bool payment = false;
        public override string AccountType { set { AccountType = "Lokata"; } }
        public override bool Payment(decimal ammount)
        {
            if (!payment)
            {
                return false;
            }
            else
                base.Payment(ammount);
            return true;
        }
        public override bool Withdraw(decimal ammount)
        {
            if (!payment)
            {
                return false;
            }
            else
                base.Withdraw(ammount);
            return true;
        }
    }
}
