using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Adult("Stefan", Gender.male));
            persons.Add(new Child("Ani", Gender.female));

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();

            var simeon = new Adult("Simeon", Gender.male);
            var simeonJuniour = new Child("Simeon Juniour", Gender.male);
            var simeonsToy = new Toy() {Color="green", Size=5 };
            Console.WriteLine(simeon.ToString());
            Console.WriteLine();
            Console.WriteLine(simeonJuniour.ToString());
            Console.WriteLine();
            Console.WriteLine(simeonsToy.ToString());
            Console.WriteLine();

            simeon.Childrens.Add(simeonJuniour);
            simeonJuniour.Toys.Add(simeonsToy);
            simeon.Isbooring = true;

            foreach (var child in simeon.Childrens)
            {
                Console.WriteLine(child.ToString());
                foreach (var toy in child.Toys)
                {
                    Console.WriteLine(toy.ToString());
                }
            }
            Console.WriteLine();

            if (simeon.Isbooring == true)
            {
                Console.WriteLine("Im very bored :|");
            }
        }
    }
}
