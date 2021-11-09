using System;
using Faker;
namespace faker_runner
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("<- UUID ->");
			Console.WriteLine(Faker.Datatype.Uuid());
			Console.WriteLine("<- BOOLEAN ->");
			Console.WriteLine(Faker.Datatype.Boolean());
			Console.WriteLine("<- RANDOM INT BETWEEN 1 and 69->");
			Console.WriteLine(Faker.Datatype.Int(1, 69));
			Console.WriteLine("<- RANDOM INT UNDEFINED ->");
			Console.WriteLine(Faker.Datatype.Int());
			Console.WriteLine("<- RANDOM FLOAT BETWEEN 1 and 69->");
			Console.WriteLine(Faker.Datatype.Double(1, 69));
			Console.WriteLine("<- RANDOM FLOAT BETWEEN UNDEFINED");
			Console.WriteLine(Faker.Datatype.Double());
			Console.WriteLine("<- RANDOM 7 CHAR STRING->");
			Console.WriteLine(Faker.Datatype.String(7));
			Console.WriteLine("<- RANDOM UNDEFINED LENGTH STRING->");
			Console.WriteLine(Faker.Datatype.String());
			Console.WriteLine("<-- RANDOM STRING ARRAY OF 10-->");
			var stringArray = Faker.Datatype.Array("string", 10);
			foreach (var item in stringArray)
			{
				Console.WriteLine(item.ToString());
			}
			Console.WriteLine("<-- RANDOM INT ARRAY OF 10-->");
			var intArray = Faker.Datatype.Array("int", 10);
			foreach (var item in intArray)
			{
				Console.WriteLine(item.ToString());
			}

			Console.WriteLine("<-- RANDOM OBJECT-->");
			Console.WriteLine(Faker.Datatype.Object());

			Console.WriteLine("<-- HACKER-->");
			Console.WriteLine(Faker.Hacker.Abbreviation());
			Console.WriteLine(Faker.Hacker.Adjective());
			Console.WriteLine(Faker.Hacker.IngVerb());
			Console.WriteLine(Faker.Hacker.Noun());
			Console.WriteLine(Faker.Hacker.Phrase());
			Console.WriteLine(Faker.Hacker.Verb());
		}
	}
}
