using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01
{
    class Dao
    {
        public static List<Employee> employees { get; set; }

        static Dao()
        {
            employees = new List<Employee>();
            Manager manager = new Manager(1, "Cezary", "Wojciechowski", 30, 4000, 5);
            Analyst analyst = new Analyst(2, "Aleksandra", "Kalinowska", 40, 3000, 7);
            Developer developer = new Developer(3, "Bartosz", "Ostrowski", 26, 5000, 3);
            RemoteDeveloper remoteDeveloper = new RemoteDeveloper(4, "Kamil", "Kowalski", 33, 3500, 4, 10);

            employees.Add(manager);
            employees.Add(analyst);
            employees.Add(developer);
            employees.Add(remoteDeveloper);
        }

        public static List<Employee> SortEmployeesBySalary()
        {
            return employees.OrderByDescending(emp => emp.Salary).ToList();
        }

        public static List<Employee> GetEmployeesByPosition(string position)
        {
            List<Employee> employeesByPos = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.GetType().ToString() == $"Lab01.{position}")
                {
                    employeesByPos.Add(employee);
                }
            }
            return employeesByPos;

        }

        public static void IncreaseSalaryForEmployee(string id, string amount)
        {
            Employee employee = employees.Find(emp => emp.Id == Convert.ToInt32(id));
            employee.IncreaseSalary(Convert.ToInt32(amount));
        }

        public static void IncreaseSalaryForAllEmployees(string amount)
        {
            foreach (var employee in employees)
            {
                employee.IncreaseSalary(Convert.ToInt32(amount));
            }
        }

        public static int GetSalarySumForPeriodAndPosition(int period, string position)
        {
            int sum = 0;
            foreach (var employee in employees)
            {
                if (employee.GetType().ToString() == $"Lab01.{position}")
                {
                    sum += employee.Salary;
                }
            }
            return sum * period;
        }

        public static List<string> GetSalariesListForPeriodAndPosition()
        {
            List<string> salariesSumPerPosition = new List<string>();
            string[] positions = { "Manager", "Analyst", "Developer", "RemoteDeveloper" };
            foreach (var position in positions)
            {
                salariesSumPerPosition.Add($"Stanowisko: {position} Miesiecznie: {GetSalarySumForPeriodAndPosition(1, position)} Rocznie:{GetSalarySumForPeriodAndPosition(12, position)}");
            }
            return salariesSumPerPosition;
        }

        public static int GetSalarySumForPeriod(int period)
        {
            int sum = 0;
            foreach (var employee in employees)
            {
                sum += employee.Salary;
            }
            return sum * period;
        }

        public static string GetSalariesList()
        {
            return $"Miesiecznie: {GetSalarySumForPeriod(1)} Rocznie:{GetSalarySumForPeriod(12)}";
        }
    }
}
