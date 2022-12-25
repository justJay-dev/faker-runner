

using System;
using Faker;
namespace FakerRunner
{
    class FinanceRunner
    {
        public static void Run()
        {
            Console.WriteLine("<-- FINANCE -->");
            Console.WriteLine("Amount--> " + Faker.Finance.Amount());
            Console.WriteLine("Account Name--> " + Faker.Finance.AccountName());
            Console.WriteLine("Routing Number--> " + Faker.Finance.RoutingNumber());
            Console.WriteLine("Mask--> " + Faker.Finance.Mask());
            Console.WriteLine("Iban --> " + Faker.Finance.Iban());
            Console.WriteLine("Iban Formatted --> " + Faker.Finance.Iban(true));

            Console.WriteLine("Bic --> " + Faker.Finance.Bic());


            Console.WriteLine("Amount 1, 100--> " + Faker.Finance.Amount(1, 100));
            Console.WriteLine("Amount 1, 100--> " + Faker.Finance.Amount(1, 100, 2, "$"));
            //Console.WriteLine("Currency Code--> " + Faker.Finance.CurrencyCode());
            Console.WriteLine("Credit Card Number--> " + Faker.Finance.CreditCardNumber("jcb"));

            Console.WriteLine("<--/ FINANCE -->");
            return;
        }
    }
}