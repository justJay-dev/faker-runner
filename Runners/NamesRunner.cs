

using System;
using Faker;
namespace FakerRunner
{
	class NamesRunner
	{
		public static void Run()
		{
			Console.WriteLine("<-- NAMES -->");
			Console.WriteLine("FirstName DEFAULT--> " + Faker.Name.FirstName());
			Console.WriteLine("FirstName MASC--> " + Faker.Name.FirstName(0));
			Console.WriteLine("FirstName FEM--> " + Faker.Name.FirstName(1));
			Console.WriteLine("LastName --> " + Faker.Name.LastName());
			Console.WriteLine("FindName FIRST--> " + Faker.Name.FindName(lastName: "LastnamingTon"));
			Console.WriteLine("FindName FIRST, MASC--> " + Faker.Name.FindName(lastName: "LastnamingTon", presentation: 0));
			Console.WriteLine("FindName FIRST, FEM--> " + Faker.Name.FindName(lastName: "LastnamingTon", presentation: 1));
			Console.WriteLine("FindName LAST--> " + Faker.Name.FindName(firstName: "Firstnamius"));
			Console.WriteLine("JobTitle--> " + Faker.Name.JobTitle());
			Console.WriteLine("Title--> " + Faker.Name.Title());
			Console.WriteLine("Prefix--> " + Faker.Name.Prefix());
			Console.WriteLine("Prefix MASC--> " + Faker.Name.Prefix(0));
			Console.WriteLine("Prefix FEM--> " + Faker.Name.Prefix(1));
			Console.WriteLine("<--/ NAMES-->");
			return;
		}
	}
}