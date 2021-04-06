using System;
using Lab03Library;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            DocumentManager dm = new DocumentManager();

            dm.Add(new Volume(8370541534, "Narrenturm", 2002, 588, "Andrzej Sapkowski", 1, 3));
            dm.Add(new Volume(9788375781403, "Boży bojownicy", 2004, 640, "Andrzej Sapkowski", 2, 3));
            dm.Add(new Volume(9788375781410, "Lux perpetua", 2006, 608, "Andrzej Sapkowski", 3, 3));
            dm.Add(new Book(8373272267, "Lalka", 2021, 668, "Bolesław Prus"));
            dm.Add(new Book(9788373272248, "Chłopi", 2020, 718, "Władysław Reymont"));
            dm.Add(new Magazine(23917962, "CD-Action", 2021, 148, 319, Frequencies.Monthly));
            dm.Add(new Magazine(63162905, "Świat Wiedzy", 2021, 112, 211, Frequencies.Monthly));

            dm.Add(new Volume(9788375781410, "Lux perpetua", 2006, 608, "Andrzej Sapkowski", 3, 3));
            //dm.Add(new Volume(3242424, "Boży bojownicy", 2004, 640, "Andrzej Sapkowski", 4, 3));
            Console.WriteLine("===========Lista wszystkich==============");
            dm.ListToConsole(dm.Documents);
            Console.WriteLine("===========GetByISBN==============");
            Console.WriteLine(dm.GetByISBN(8370541534));
            Console.WriteLine("===========GetByPhraseInTitle==============");
            var filteredList = dm.GetByPhraseInTitle("Świat");
            dm.ListToConsole(filteredList);
            Console.WriteLine("===========GetByFrequency==============");
            filteredList = dm.GetByFrequency(Frequencies.Monthly);
            dm.ListToConsole(filteredList);
            Console.WriteLine("===========GetVolumesByTitle==============");
            filteredList = dm.GetVolumesByTitle("Narrenturm");
            dm.ListToConsole(filteredList);
            Console.WriteLine("===========Drukowanie publikacji==============");
            Console.WriteLine(dm.Documents[0].Print());

            }
            catch (Exception ex)
            {
                HandleException.Handle(ex);
            }
        }
    }
}
