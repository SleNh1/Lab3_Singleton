using System;
using EarthLibrary;

namespace EarthConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Singleton Pattern Demo: Planet Earth ===\n");

            Earth earthInstance = Earth.Instance;

            Console.WriteLine("Введіть назву міста:");
            string city1 = Console.ReadLine();

            Console.WriteLine("Введіть широту (наприклад, 50,45):");
            double lat1 = double.Parse(Console.ReadLine());

            string result1 = earthInstance.GetSeason(city1, lat1, DateTime.Now);
            Console.WriteLine(result1);

            Console.WriteLine("\n-----------------------------------\n");

            Console.WriteLine("Перевірка для іншого міста через той самий Singleton...");

            string city2 = "Сідней";
            double lat2 = -33.86;
            DateTime summerDate = new DateTime(2023, 1, 15);

            string result2 = Earth.Instance.GetSeason(city2, lat2, summerDate);
            Console.WriteLine(result2);

            Console.WriteLine("\nПеревірка посилань:");
            Earth earth2 = Earth.Instance;
            if (earthInstance == earth2)
            {
                Console.WriteLine("Це той самий об'єкт! (Singleton працює)");
            }

            Console.ReadKey();
        }
    }
}