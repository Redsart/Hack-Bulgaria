using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            List<ILandAnimal> landAnimals = new List<ILandAnimal>();
            landAnimals.Add(new Cat());
            landAnimals.Add(new Dog());

            foreach (var animal in landAnimals)
	        {
                Console.WriteLine(animal.Greet());
	        }
            Console.WriteLine();

            var list = new List<Animal>();
            list.Add(new Cat());
            list.Add(new Dog());
            list.Add(new Crocodile());
            list.Add(new Owl());
            list.Add(new Shark());

            foreach (var animal in list)
	        {
                Console.WriteLine(animal.Move());
	        }
        }
    }
}
