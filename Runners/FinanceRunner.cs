

using System;
using Faker;
namespace FakerRunner
{
    class FinanceRunner
    {
        public static void Run()
        {
            Console.WriteLine("<-- FINANCE -->");
            Console.WriteLine("Account DEFAULT--> " + Faker.Finance.Account());
            Console.WriteLine("Account 4 length--> " + Faker.Finance.Account(4));
            Console.WriteLine("Account Name--> " + Faker.Finance.AccountName());
            Console.WriteLine("<--/ FINANCE -->");
            return;
        }
    }
}