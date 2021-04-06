using Lab04.animals;
using Lab04.animals.human;
using System;
using System.Collections.Generic;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsManager am = new AnimalsManager();

            am.AddAnimal(new Bear("Bruno", 10, 100, 50));
            am.AddAnimal(new Boar("Tenor", 8, 80, 40));
            am.AddAnimal(new Cow("Gloria", 5, 150, 30));
            am.AddAnimal(new Elephant("Jumbo", 12, 300, 40));
            am.AddAnimal(new Tiger("Tiga", 3, 100, 60));
            am.AddAnimal(new Wolf("Toto", 4, 80, 55));

            // Nieprawidłowe
            am.AddAnimal(new Wolf("To", 4, 80, 55));
            am.AddAnimal(new Wolf("Toto", 4, 80, 1300));

            am.CreateHerbivoresFromAnimals();
            am.CreateCarnivoresFromAnimals();

            Console.WriteLine("==========Wszystkie zwierzęta==========");
            am.showAnimals();
            Console.WriteLine("==========Roślinożerne==========");
            am.showHerbivores();
            Console.WriteLine("==========Mięsożerne==========");
            am.showCarnivores();

            Console.WriteLine("==========Karmienie grupowe==========");
            am.FeedHerbivores();
            am.FeedCarnivores();

            Console.WriteLine("==========Karmienie indywidualne==========");
            AnimalsManager.FeedHerbivore(am.herbivores[2]);
            AnimalsManager.FeedCarnivore(am.carnivores[2]);


            Human human = new Human
            {
                Name = "Adam",
                Age = 30,
                Height = 180,
                Speed = 20,
                IQ = 100,
                Cars =
                {
                    new Car("Audi", 20000),
                    new Car("BMW", 25000),
                    new Car("Mazda", 25000)
                },
                Houses =
                {
                    new House(50, 600000),
                    new House(45, 500000),
                }

            };

            Human human2 = new Human
            {
                Name = "Marek",
                Age = 22,
                Height = 183,
                Speed = 18,
                IQ = 110,
                Cars =
                {
                    new Car("Opel", 30000),
                    new Car("Hyundai", 40000)
                },
                Houses =
                {
                    new House(50, 650000),
                    new House(45, 450000),
                    new House(70, 800000)
                }

            };


            Console.WriteLine("==========Samochody Adama==========");
            foreach (Car car in human)
            {
                Console.WriteLine($"Model {car.Model}, cena {car.Price}");
            }
            Console.WriteLine("==========Domy Adama==========");
            foreach (House house in human.GetHousesByPrice())
            {
                Console.WriteLine($"Powierzchnia {house.Area}, cena {house.Price}");
            }

            Console.WriteLine("==========Klon zwierzaka==========");
            var bearClone = am.animals[0].Clone();
            Console.WriteLine(bearClone);

            Console.WriteLine("==========Klon człowieka==========");
            Human humanClone = (Human) human.Clone();
            Console.WriteLine(humanClone);
            Console.WriteLine(humanClone.Cars[0]);

            Console.WriteLine("==========Sortowanie po IQ==========");
            List<Human> humans = new List<Human>();
            humans.Add(human);
            humans.Add(human2);
            humans.Sort();

            foreach (Human h in humans)
            {
                Console.WriteLine(h);
            }

            Console.WriteLine("==========Sortowanie po ilości samochodów==========");
            humans.Sort(Human.SortByCarsCount);
            foreach (Human h in humans)
            {
                Console.WriteLine(h);
            }

            Console.WriteLine("==========Sortowanie po ilości domów==========");
            humans.Sort(Human.SortByHousesCount);
            foreach (Human h in humans)
            {
                Console.WriteLine(h);
            }

            Console.WriteLine("==========Sortowanie po wartości samochodów i domów==========");
            humans.Sort(Human.SortByAmount);
            foreach (Human h in humans)
            {
                Console.WriteLine(h);
            }

        }
    }
}
