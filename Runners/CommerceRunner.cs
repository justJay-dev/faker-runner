

using System;
using Faker;
namespace FakerRunner
{
	class CommerceRunner
	{
		public static void Run()
		{
			Console.WriteLine("<-- COMMERCE -->");
			Console.WriteLine("Color--> " + Faker.Commerce.Color());
			Console.WriteLine("Department--> " + Faker.Commerce.Department());
			Console.WriteLine("ProductName--> " + Faker.Commerce.ProductName());
			Console.WriteLine("ProductAdjective--> " + Faker.Commerce.ProductAdjective());
			Console.WriteLine("ProductMaterial--> " + Faker.Commerce.ProductMaterial());
			Console.WriteLine("Product--> " + Faker.Commerce.Product());
			Console.WriteLine("Price --> " + Faker.Commerce.Price(1, 69, 2, "$"));
			Console.WriteLine("<--/ COMMERCE -->");
			return;
		}
	}
}