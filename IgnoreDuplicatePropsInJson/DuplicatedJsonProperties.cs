using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DuplicatedJsonProperties
{
	class DuplicatedJsonProperties
	{
		private const string data =
@"{
	""language"": ""esperanto"",
	""title"": ""Primeiro Manual de Esperanto"",
	""title"": ""Fundamento de Esperanto"",
	""author"" : ""Ludwik Lejzer Zamenhof""
}";

		static void Main(string[] args)
		{
			Console.WriteLine("---Input---");
			Console.WriteLine(data);

			PrintJson("Throw exception on duplicates", DuplicatePropertyNameHandling.Error);
			PrintJson("Ignore duplicates", DuplicatePropertyNameHandling.Ignore);
			PrintJson("Replace duplicates with the last property", DuplicatePropertyNameHandling.Replace);

			Console.ReadKey();
		}

		private static void PrintJson(string header, DuplicatePropertyNameHandling duplicateFlag)
		{
			try
			{
				Console.WriteLine();
				Console.WriteLine("---" + header + "---");

				JsonLoadSettings jsonLoadSettings = (duplicateFlag == DuplicatePropertyNameHandling.Replace)
					? null
					: new JsonLoadSettings { DuplicatePropertyNameHandling = duplicateFlag };

				JToken jToken = JToken.Parse(data, jsonLoadSettings);

				Console.WriteLine(jToken.ToString(Formatting.Indented));
				Console.WriteLine();
			}
			catch (JsonReaderException jsonReaderException)
			{
				Console.WriteLine("Exception thrown: " + jsonReaderException.Message);
			}
		}
	}
}
