using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.animals.human
{
    class House : ICloneable
    {
        public int Area { get; set; }
        public int Price { get; set; }

        public House()
        {
        }
        public House(int area, int price)
        {
            Area = area;
            Price = price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Model {Area}, cena {Price}";
        }
    }
}
