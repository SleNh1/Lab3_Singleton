using System;

namespace EarthLibrary
{
    public sealed class Earth
    {
        private static Earth _instance = null;

        private Earth()
        {
            Console.WriteLine("--- Створено єдиний екземпляр планети Земля ---");
        }

        public static Earth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Earth();
                }
                return _instance;
            }
        }

        public string GetSeason(string city, double latitude, DateTime date)
        {
            bool isNorthernHemisphere = latitude >= 0;

            int month = date.Month;
            string season = "";

            if (month == 12 || month == 1 || month == 2) season = "Зима";
            else if (month >= 3 && month <= 5) season = "Весна";
            else if (month >= 6 && month <= 8) season = "Літо";
            else season = "Осінь";

            if (!isNorthernHemisphere)
            {
                if (season == "Зима") season = "Літо";
                else if (season == "Літо") season = "Зима";
                else if (season == "Весна") season = "Осінь";
                else if (season == "Осінь") season = "Весна";
            }

            return $"У місті {city} ({date.ToShortDateString()}) зараз: {season}";
        }
    }
}