using System;
using System.Collections.Generic;

namespace lektion_10___luay
{
    class Program
    {
        public static void Main()
        {
            List<Person> personlista = new List<Person>();

            Person p = new Person("Luke Skywalker", 20, "Moisture fram 1138, Tatooine");
            personlista.Add(p);
            personlista.Add(new Person("Lando Calrissian", 28, "Cloud City, Bespin"));

            foreach (Person element in personlista)
            {
                Console.WriteLine(element.Namn);
                Console.WriteLine(element.Ålder);
                Console.WriteLine(element.Adress);
            }


        }
    }
}
