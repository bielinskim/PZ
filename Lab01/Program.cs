using System.Collections.Generic;

namespace Lab01
{
    class Program
    {
        static string selection;

        static void Main(string[] args)
        {
            selection = "";

            Console.PrintMenu();

            while (selection != "0")
            {
                selection = Console.ReadMenuSelection();
                switch (selection)
                {
                    case "1":
                        ShowEmployees();
                        break;
                    case "2":
                        ShowEmployeesBySalary();
                        break;
                    case "3":
                        ShowEmployeesByPosition();
                        break;
                    case "4":
                        IncreaseSalaryForEmployee();
                        break;
                    case "5":
                        IncreaseSalaryForAllEmployees();
                        break;
                    case "6":
                        ShowSalariesSumPerPosition();
                        break;
                    case "7":
                        ShowSalariesSum();
                        break;
                    case "0":
                        Close();
                        break;
                    default:
                        break;
                }
            }
        }

        static void ShowEmployees()
        {
            Console.PrintList(Dao.employees);
        }

        static void ShowEmployeesBySalary()
        {
            Console.PrintList(Dao.SortEmployeesBySalary());
        }

        static void ShowEmployeesByPosition()
        {
            string position = Console.ReadPosition();
            Console.PrintList(Dao.GetEmployeesByPosition(position));
        }
        static void IncreaseSalaryForEmployee()
        {
            string id = Console.ReadEmployeeId();
            string amount = Console.ReadIncreaseAmount();
            Dao.IncreaseSalaryForEmployee(id, amount);
        }

        static void IncreaseSalaryForAllEmployees()
        {
            string amount = Console.ReadIncreaseAmount();
            Dao.IncreaseSalaryForAllEmployees(amount);
        }

        static void ShowSalariesSumPerPosition()
        {
            Console.PrintStringList(Dao.GetSalariesListForPeriodAndPosition());        
        }

        static void ShowSalariesSum()
        {
            Console.Print(Dao.GetSalariesList());
        }

        static void Close()
        {
            Console.PrintExitMsg();
        }

    }

}
