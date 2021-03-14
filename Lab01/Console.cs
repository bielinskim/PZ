using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Console
    {
        static ConsoleColor origialConsoleColor = System.Console.ForegroundColor;
        static public void PrintMenu()
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("1. Wyświetlenie wszystkich pracowników");
            System.Console.WriteLine("2. Wyświetlenie wszystkich pracowników posortowanych malejąco wzgledem pensji");
            System.Console.WriteLine("3. Wyświetlenie pracowników na wybranym stanowisku");
            System.Console.WriteLine("4. Zwiększenie pensji wybranego pracownika");
            System.Console.WriteLine("5. Zwiększenie pensji dla wszystkich pracowników");
            System.Console.WriteLine("6. Pokaż miesieczną i roczną kwotę potrzebną na wypłaty dla każdego ze stanowisk");
            System.Console.WriteLine("7. Pokaż miesieczną i roczną kwotę potrzebną na wypłaty dla wszystkich pracowników");
            System.Console.WriteLine("0. Wyjście");
            System.Console.ForegroundColor = origialConsoleColor;
        }

        static public string ReadMenuSelection()
        {
            System.Console.WriteLine("Wybierz opcję z menu:");
            return System.Console.ReadLine();
        }

        static public void PrintExitMsg()
        {
            System.Console.WriteLine("Bye bye");
        }

        public static void PrintList(List<Employee> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item.ToString());
            }
        }

        public static void PrintStringList(List<string> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item.ToString());
            }
        }

        public static void Print(string item)
        {
            System.Console.WriteLine(item.ToString());
        }

        static public string ReadPosition()
        {
            System.Console.WriteLine("Wpisz nazwę stanowiska:");
            return System.Console.ReadLine();
        }

        static public string ReadEmployeeId()
        {
            System.Console.WriteLine("Wpisz id pracownika:");
            return System.Console.ReadLine();
        }
        static public string ReadIncreaseAmount()
        {
            System.Console.WriteLine("Wpisz wysokość podwyżki:");
            return System.Console.ReadLine();
        }
    }
}
