

using System;
using System.Collections.Generic;
using Faker;
namespace FakerRunner
{
	class HelpersRunner
	{
		public static void Run()
		{
			string[] stringArray = new string[] { "uwu", "owo" };
			List<string> stringList = new List<string> { "owo", "ewuwu" };

			Console.WriteLine("<-- HELPERS -->");
			Console.WriteLine("Randomize, Array--> " + Faker.Helpers.Randomize(stringArray));
			Console.WriteLine("Randomize, List--> " + Faker.Helpers.Randomize(stringList));
			Console.WriteLine("<--/ HELPERS -->");
			return;
		}
	}
}