using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    class Customer
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }

        public Customer(string name, int phoneNumber, string adress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }

        public Customer()
        {
        }
    }
}
