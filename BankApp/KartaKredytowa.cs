using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class KartaKredytowa:Account
    {
        
        public override string AccountType { set { AccountType = "Karta kredytowa"; } }
        public override bool Payment(decimal ammount)
        {
            if (ammount>Balance)
            {
                return false;
            }
            else
                base.Withdraw(ammount);
            return true;
        }
    }
}
