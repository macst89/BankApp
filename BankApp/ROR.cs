using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ROR:Account
    {

        public override string AccountType { set { AccountType = "ROR"; } }
        public override bool Withdraw(decimal ammount)
        {
            if (ammount > Balance)
            {
                return false;
            }
            else
                base.Withdraw(ammount);
            return true;
        }
    }
}
