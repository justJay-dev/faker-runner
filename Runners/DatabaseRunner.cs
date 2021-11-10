
using System;
using Faker;
namespace FakerRunner
{
	class DatabaseRunner
	{
		public static void Run()
		{
			Console.WriteLine("<-- DATABASE -->");
			Console.WriteLine("Column--> " + Faker.Database.Column());
			Console.WriteLine("Type--> " + Faker.Database.Type());
			Console.WriteLine("Collation--> " + Faker.Database.Collation());
			Console.WriteLine("Engine--> " + Faker.Database.Engine());
			Console.WriteLine("<--/ DATABASE-->");
			return;
		}
	}
}