using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class AnimalsManager
    {
        public List<Animal> animals = new List<Animal>();
        public List<Herbivores> herbivores = new List<Herbivores>();
        public List<Carnivores> carnivores = new List<Carnivores>();

        public void AddAnimal(Animal a)
        {
            try
            {
                if (a.Name.Length < 3)
                {
                    throw new NameTooShortException("Nazwa nie może mieć mniej niż 3 znaki");
                }
                if (a.Speed > 1225)
                {
                    throw new SpeedToHighException("Szybkość nie może być większa od prędkości światła");
                }
                animals.Add(a);
            }
            catch (Exception ex)
            {
                ConsoleColor origialConsoleColor = System.Console.ForegroundColor;
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                System.Console.ForegroundColor = origialConsoleColor;
            }
        }

        public void AddHerbivores(Herbivores h)
        {
            herbivores.Add(h);
        }

        public void AddCarnivores(Carnivores c)
        {
            carnivores.Add(c);
        }

        public void CreateHerbivoresFromAnimals()
        {
            foreach (var a in animals)
            {
                if (a is Herbivores)
                {
                    herbivores.Add((Herbivores)a);
                }
            }
        }

        public void CreateCarnivoresFromAnimals()
        {
            foreach (var a in animals)
            {
                if (a is Carnivores)
                {
                    carnivores.Add((Carnivores)a);
                }
            }
        }

        public void FeedHerbivores()
        {
            foreach (var h in herbivores)
            {
                h.FindFood();
                h.EatPlant();
            }
        }

        public void FeedCarnivores()
        {
            foreach (var c in carnivores)
            {
                c.FindFood();
                c.EatMeat();
            }
        }

        public static void FeedHerbivore(Herbivores h)
        {
            h.FindFood();
            h.EatPlant();
        }

        public static void FeedCarnivore(Carnivores c)
        {
            c.FindFood();
            c.EatMeat();
        }

        public void showAnimals()
        {
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }
        }

        public void showHerbivores()
        {
            foreach (var h in herbivores)
            {
                Console.WriteLine(h);
            }
        }

        public void showCarnivores()
        {
            foreach (var c in carnivores)
            {
                Console.WriteLine(c);
            }
        }

        Animal getAnimalByName(string name)
        {
            foreach (var a in animals)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
