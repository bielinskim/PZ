using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.animals.human
{
    class Car : ICloneable
    {
        public string Model { get; set; }
        public int Price { get; set; }

        public Car()
        {
        }
        public Car(string model, int price)
        {
            Model = model;
            Price = price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Model {Model}, cena {Price}";
        }
    }
}
