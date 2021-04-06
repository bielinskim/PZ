using Lab04.animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.comparers
{
    class HousesCountComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            return x.Houses.Count.CompareTo(y.Houses.Count);
        }
    }
}
