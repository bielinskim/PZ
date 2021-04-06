using Lab04.animals.human;
using Lab04.comparers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.animals
{
    class Human : Animal, IEnumerable<Car>, IComparable<Human>
    {
        public int IQ { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();
        public List<House> Houses { get; set; } = new List<House>();

        public int Amount
        {
            get
            {
                return Cars.Sum(c => c.Price) + Houses.Sum(h => h.Price);
            }
        }

        public static IComparer<Human> SortByCarsCount
        {
            get
             {
                return new CarsCountComparer();
            }
        }

        public static IComparer<Human> SortByHousesCount
        {
            get
            {
                return new HousesCountComparer();
            }
        }

        public static IComparer<Human> SortByAmount
        {
            get
            {
                return new AmountComparer();
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, IQ: {IQ}";
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        public IEnumerable GetHousesByPrice(int price = 0)
        {
            foreach (House house in Houses)
            {
                if(house.Price > price)
                {
                    yield return house;
                }
            }
        }

        public object Clone()
        { 
            Human human = (Human) this.MemberwiseClone();
            human.Cars = new List<Car>();
            human.Houses = new List<House>();
            foreach (Car car in Cars)
            {
                human.Cars.Add((Car) car.Clone());
            }
            foreach (House house in Houses)
            {
                human.Houses.Add((House) house.Clone());
            }
            return human;
        }

        public int CompareTo(Human h)
        {
            return IQ.CompareTo(h.IQ);
        }
    }
}
