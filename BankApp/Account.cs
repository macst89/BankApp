using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        private int _accountNo = 0;
        public int AccountNo {
            set
            {
                Random rnd = new Random();
                _accountNo = rnd.Next(0, 100000);     
            }
        }
        public virtual string AccountType { get; set; }
        public decimal Balance { get; set; }
        public virtual bool Payment(decimal ammount)
        {
            if (ammount > 0)
            {
                Balance += ammount;
                Operations.Add(new Operation { Type = "Wpłata", Balance = Balance, Date = DateTime.Now });
                return true;
            }
            else
                return false;
        }
        public virtual bool Withdraw(decimal ammount)
        {
            
                Balance -= ammount;
            Operations.Add(new Operation { Type = "Wypłata", Balance = Balance, Date = DateTime.Now });
            return true;
        }
        private ObservableCollection<Operation> _operations = new ObservableCollection<Operation>();
        public ObservableCollection<Operation> Operations {
            get { return _operations; }
            set { _operations = Operations; }
        }

    }
}
