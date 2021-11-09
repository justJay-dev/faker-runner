using System;
using Faker;
namespace FakerRunner
{
	class DataypeRunner
	{
		public static void Run()
		{


			Console.WriteLine("<-- DATATYPE -->");
			Console.WriteLine("<-- UUID -->");
			Console.WriteLine(Faker.Datatype.Uuid());
			Console.WriteLine("<-- BOOLEAN -->");
			Console.WriteLine(Faker.Datatype.Boolean());
			Console.WriteLine("<-- RANDOM INT BETWEEN 1 and 69 -->");
			Console.WriteLine(Faker.Datatype.Int(1, 69));
			Console.WriteLine("<-- RANDOM INT UNDEFINED -->");
			Console.WriteLine(Faker.Datatype.Int());
			Console.WriteLine("<-- RANDOM FLOAT BETWEEN 1 and 69 -->");
			Console.WriteLine(Faker.Datatype.Double(1, 69));
			Console.WriteLine("<-- RANDOM FLOAT BETWEEN UNDEFINED -->");
			Console.WriteLine(Faker.Datatype.Double());
			Console.WriteLine("<-- RANDOM 7 CHAR STRING -->");
			Console.WriteLine(Faker.Datatype.String(7));
			Console.WriteLine("<-- RANDOM UNDEFINED LENGTH STRING -->");
			Console.WriteLine(Faker.Datatype.String());
			Console.WriteLine("<-- RANDOM STRING ARRAY OF 10 -->");
			var stringArray = Faker.Datatype.Array("string", 10);
			foreach (var item in stringArray)
			{
				Console.WriteLine(item.ToString() + ",");
			}
			Console.WriteLine("<-- RANDOM INT ARRAY OF 10 -->");
			var intArray = Faker.Datatype.Array("int", 10);
			foreach (var item in intArray)
			{
				Console.WriteLine(item.ToString() + ",");
			}

			Console.WriteLine("<-- RANDOM OBJECT-->");
			Console.WriteLine(Faker.Datatype.Object(1, "string"));
			Console.WriteLine(Faker.Datatype.Object(1, "number"));
			Console.WriteLine(Faker.Datatype.Object(1, "boolean"));
			Console.WriteLine("<--/ DATATYPE -->");
			return;
		}
	}
}