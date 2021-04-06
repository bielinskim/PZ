using Lab04.animals;
using Lab04.animals.human;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.comparers
{
    class AmountComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            return x.Amount.CompareTo(y.Amount);
        }
    }
}
