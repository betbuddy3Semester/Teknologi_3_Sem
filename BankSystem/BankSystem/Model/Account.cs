using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    class Account
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public Account(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public Account()
        {
        }
    }
}
