using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Customer
    {
        private string name;
        private int age;
        private string address;
        private float amountOwed;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public float AmountOwed
        {
            get { return this.amountOwed; }
            set { this.amountOwed = value; }
        }

        public string GetInformation() // (Hint: refer to week3 lecture note, page10)
        {
            return "Name: " + this.Name + ", Age: " + this.Age + ", Address: " + this.Address + ", Amount Owed: £" + this.AmountOwed.ToString("F2");
        }
    }
}