
using System;
using Faker;
namespace FakerRunner
{
    class DateRunner
    {
        public static void Run()
        {
            Console.WriteLine("<-- DATE -->");
            Console.WriteLine("Month--> " + Faker.Date.Month());
            Console.WriteLine("MonthAbbr--> " + Faker.Date.Month(true));
            Console.WriteLine("Weekday--> " + Faker.Date.Weekday());
            Console.WriteLine("Weekday Abbr--> " + Faker.Date.Weekday(true));
            Console.WriteLine("Past--> " + Faker.Date.Past(69));
            Console.WriteLine("Future--> " + Faker.Date.Future(2));
            Console.WriteLine("Between--> " + Faker.Date.Between("06/01/1990", "06/01/1991"));
            Console.WriteLine("Recent--> " + Faker.Date.Recent(15, "06/01/1991"));
            Console.WriteLine("Soon--> " + Faker.Date.Soon(15, "06/01/1991"));
            Console.WriteLine("<--/ DATE -->");
            return;
        }
    }
}