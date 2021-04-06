using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.animals
{
    class Boar : Animal, Herbivores, Carnivores
    {
        public Boar()
        {
        }

        public Boar(string name, int age, int height, int speed) : base(name, age, height, speed)
        {
        }

        void Herbivores.FindFood()
        {
            Console.WriteLine($"{GetType().Name} {Name} znalazł/a roslinę");
        }
        void Carnivores.FindFood()
        {
            Console.WriteLine($"{GetType().Name} {Name} znalazł/a mięso");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{GetType().Name} {Name} zjadł/a roslinę");
        }

        public void EatMeat()
        {
            Console.WriteLine($"{GetType().Name} {Name} zjadł/a mięso");
        }
    }
}
