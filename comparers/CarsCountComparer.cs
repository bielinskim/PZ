using Lab04.animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.comparers
{
    class CarsCountComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            return x.Cars.Count.CompareTo(y.Cars.Count);
        }
    }
}
