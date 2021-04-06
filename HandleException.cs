using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    static class HandleException
    {
        
        static public void Handle(Exception ex)
        {
            ConsoleColor origialConsoleColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Red;
            if (ex is ApplicationException)
            {
                Console.WriteLine("Wyjątek aplikacyjny");
            } else
            {
                Console.WriteLine("Wyjątek systemowy");
            }
            Console.WriteLine($"Pełna nazwa kwalifikowana: {ex.GetType()}");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"TargetSite: {ex.TargetSite}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            Console.WriteLine($"HelpLink: {ex.HelpLink}");
            Console.WriteLine($"Data IsFixedSize: {ex.Data.IsFixedSize}");
            Console.WriteLine($"Data IsReadOnly: {ex.Data.IsReadOnly}");
            Console.WriteLine($"Data IsSynchronized: {ex.Data.IsSynchronized}");
            System.Console.ForegroundColor = origialConsoleColor;

            if(ex.InnerException != null)
            {
                Handle(ex.InnerException);
            }
        }
    }
}
