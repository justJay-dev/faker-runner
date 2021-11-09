using System;
using Faker;
namespace FakerRunner
{
	class HackerRunner
	{
		public static void Run()
		{
			Console.WriteLine("<-- HACKER -->");
			Console.WriteLine("Abbreviation --> " + Faker.Hacker.Abbreviation());
			Console.WriteLine("Adjective --> " + Faker.Hacker.Adjective());
			Console.WriteLine("IngVerb --> " + Faker.Hacker.IngVerb());
			Console.WriteLine("Noun --> " + Faker.Hacker.Noun());
			Console.WriteLine("Verb --> " + Faker.Hacker.Verb());
			Console.WriteLine("Phrase --> " + Faker.Hacker.Phrase());
			Console.WriteLine("<--/ HACKER -->");
			return;
		}
	}
}