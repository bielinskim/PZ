using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Animal : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Speed { get; set; }

        public Animal()
        {
        }

        public Animal(string name, int age, int height, int speed)
        {
            Name = name;
            Age = age;
            Height = height;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}, height: {Height}, speed: {Speed}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
