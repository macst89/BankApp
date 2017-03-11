using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Person
    {
        private string _pesel;
        private char _gender;
        private DateTime _birthDate;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get { return _pesel; } set { _pesel = Pesel; } }
        public DateTime BirthDate { get { return _birthDate;  }
            set
            {
                if (_pesel != null)
                    _birthDate = DateTime.Parse(("19" + _pesel.Substring(0, 2) + "-" + _pesel.Substring(2, 2) + "-" + _pesel.Substring(4, 2)));
                else
                    throw new NullReferenceException();
            }
        }
        public char Gender { get { return _gender; }
            set
            {
                if (_pesel != null)
                {
                    char g = Char.Parse(_pesel.Substring(10, 1));
                    _gender = (g == 'M') ? 'M' : 'K';
                }
            }
        }
        private ObservableCollection<Address> _address = new ObservableCollection<Address>();
        public ObservableCollection<Address> Address { get; set; }
        private ObservableCollection<Account> _account = new ObservableCollection<Account>();
        public ObservableCollection<Account> Account { get; set; }

    }
}
