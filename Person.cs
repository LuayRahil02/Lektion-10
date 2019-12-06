using System;
using System.Collections.Generic;
using System.Text;

namespace lektion_10___luay
{
    class Person
    {
        private string namn;
        private int ålder;
        private string adress;

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public int Ålder
        {
            get { return ålder; }
            set { ålder = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public Person(string n, int å, string a)
        {
            Namn = n;
            Ålder = å;
            Adress = a;
        }
        public Person() { }
    }
}
