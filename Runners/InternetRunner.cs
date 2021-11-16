using System;
using Faker;
namespace FakerRunner
{
    class InternetRunner
    {
        public static void Run()
        {
            Console.WriteLine("<-- INTERNET -->");
            Console.WriteLine("Email DEFAULT--> " + Faker.Internet.Email());
            Console.WriteLine("Email Jay Simpson--> " + Faker.Internet.Email(firstName: "Jay", lastName: "Simpson"));
            Console.WriteLine("Email EXAMPLE--> " + Faker.Internet.ExampleEmail());
            Console.WriteLine("UserName --> " + Faker.Internet.UserName());

            Console.WriteLine("<--/ INTENRET -->");
            return;
        }
    }
}