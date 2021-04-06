using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.animals
{
    class Elephant : Animal, Herbivores
    {
        public Elephant()
        {
        }

        public Elephant(string name, int age, int height, int speed) : base(name, age, height, speed)
        {
        }

        public void FindFood()
        {
            Console.WriteLine($"{GetType().Name} {Name} znalazł/a roslinę");
        }
        public void EatPlant()
        {
            Console.WriteLine($"{GetType().Name} {Name} zjadł/a roslinę");
        }
    }
}
