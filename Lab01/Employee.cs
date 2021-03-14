using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        protected Employee()
        {
        }

        protected Employee(int id, string firstName, string lastName, int age, int salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public virtual void IncreaseSalary(int amount)
        {
            Salary += amount;
        }

        public override string ToString()
        {
            return $"Id {Id} Imię {FirstName} Nazwisko {LastName} Wiek {Age} Pensja {Salary}";
        }

    }

    class Manager : Employee
    {
        public int ProjectsCount { get; set; }

        public Manager()
        {
        }

        public Manager(int id, string firstName, string lastName, int age, int salary, int projectsCount) : base(id, firstName, lastName, age, salary)
        {
            ProjectsCount = projectsCount;
        }

        public override void IncreaseSalary(int amount)
        {
            base.IncreaseSalary(amount);
            Salary += 100 * ProjectsCount;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Liczba projektów {ProjectsCount}";
        }
    }

    class Analyst : Employee
    {
        public int ClientsCount { get; set; }

        public Analyst()
        {
        }

        public Analyst(int id, string firstName, string lastName, int age, int salary, int clientsCount) : base(id, firstName, lastName, age, salary)
        {
            ClientsCount = clientsCount;
        }

        public override void IncreaseSalary(int amount)
        {
            base.IncreaseSalary(amount);
            Salary += 100 * ClientsCount;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Liczba klientów {ClientsCount}";
        }
    }

    class Developer : Employee
    {
        public int TechnologiesCount { get; set; }

        public Developer()
        {
        }

        public Developer(int id, string firstName, string lastName, int age, int salary, int technologiesCount) : base(id, firstName, lastName, age, salary)
        {
            TechnologiesCount = technologiesCount;
        }

        public override void IncreaseSalary(int amount)
        {
            base.IncreaseSalary(amount);
            Salary += 100 * TechnologiesCount;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Liczba technologii {TechnologiesCount}";
        }
    }

    class RemoteDeveloper : Developer
    {
        public int Distance { get; set; }

        public RemoteDeveloper()
        {
        }

        public RemoteDeveloper(int id, string firstName, string lastName, int age, int salary, int technologiesCount, int distance) : base(id, firstName, lastName, age, salary, technologiesCount)
        {
            Distance = distance;
        }

        public override void IncreaseSalary(int amount)
        {
            base.IncreaseSalary(amount);
            Salary += 10 * Distance;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Odległość {Distance}";
        }
    }

  
}
