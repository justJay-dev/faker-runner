

using System;
using Faker;
namespace FakerRunner
{
	class CompanyRunner
	{
		public static void Run()
		{
			Console.WriteLine("<-- COMPANY -->");
			Console.WriteLine("<-- Suffixes -->");
			foreach (var item in Faker.Company.Suffixes())
			{
				Console.WriteLine(item.ToString() + ",");
			}
			Console.WriteLine("Company Suffix--> " + Faker.Company.CompanySuffix());
			Console.WriteLine("CatchPhraseAdjective--> " + Faker.Company.CatchPhraseAdjective());
			Console.WriteLine("CatchPhraseDescriptor--> " + Faker.Company.CatchPhraseDescriptor());
			Console.WriteLine("CatchPhraseNoun--> " + Faker.Company.CatchPhraseNoun());
			Console.WriteLine("CatchPhrase--> " + Faker.Company.CatchPhrase());
			Console.WriteLine("BS Adjective--> " + Faker.Company.BSAdjective());
			Console.WriteLine("BS Buzz--> " + Faker.Company.BSBuzz());
			Console.WriteLine("BS Noun--> " + Faker.Company.BSNoun());
			Console.WriteLine("BS--> " + Faker.Company.BS());
			Console.WriteLine("<--/ COMPANY-->");
			return;
		}
	}
}