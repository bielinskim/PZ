﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.animals
{
    class Tiger : Animal, Carnivores
    {
        public Tiger()
        {
        }

        public Tiger(string name, int age, int height, int speed) : base(name, age, height, speed)
        {
        }

        public void FindFood()
        {
            Console.WriteLine($"{GetType().Name} {Name} znalazł/a mięso");
        }
        public void EatMeat()
        {
            Console.WriteLine($"{GetType().Name} {Name} zjadł/a mięso");
        }
    }
}