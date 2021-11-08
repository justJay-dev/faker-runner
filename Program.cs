using System;
using Faker.Datatype;
namespace faker_runner
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("<- UUID ->");
			Console.WriteLine(Faker.Datatype.Uuid.Next());
			Console.WriteLine("<- BOOLEAN ->");
			Console.WriteLine(Faker.Datatype.Boolean.Next());
			Console.WriteLine("<- RANDOM INT->");
			Console.WriteLine(Faker.Datatype.Int.Next(1, 69));
			Console.WriteLine("<- RANDOM FLOAT->");
			Console.WriteLine(Faker.Datatype.Float.Next(1, 69));
			//broken
			Console.WriteLine("<- RANDOM 7 CHAR STRING->");
			Console.WriteLine(Faker.Datatype.String.Next(7));
		}
	}
}
