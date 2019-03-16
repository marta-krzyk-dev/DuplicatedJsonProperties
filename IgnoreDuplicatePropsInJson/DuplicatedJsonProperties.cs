using System;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DuplicatedJsonProperties
{
	class DuplicatedJsonProperties
	{
		private const string data = @"{
	""language"": ""esperanto"",
	""title"": ""Primeiro Manual de Esperanto"",
	""title"": ""Shakespeare"",
	""author"" : ""Ludwik Lejzer Zamenhof""
}";

		static void Main(string[] args)
		{
			Console.WriteLine("Input:");
			Console.WriteLine(data);

			CodeThrowExceptionOnDuplicates(data);
			CodeIgnoreDuplicates(data);

			Console.ReadKey();
		}

		private static void CodeIgnoreDuplicates(string data)
		{
			JObject jObject = JObject.Parse(data, new JsonLoadSettings() { DuplicatePropertyNameHandling = DuplicatePropertyNameHandling.Ignore });

			var properties = jObject.Properties();

			Console.WriteLine("Properties:");
			int i = 0;
			foreach (JProperty jProperty in properties)
			{
				Console.WriteLine($"{++i}. {jProperty.Name} - {jProperty.Value}");
			}
			Debug.Assert(properties.Count() == 3, "Unexpected number of properties.");
		}

		private static void CodeThrowExceptionOnDuplicates(string input)
		{
			try
			{
				JToken.Parse(input, new JsonLoadSettings() { DuplicatePropertyNameHandling = DuplicatePropertyNameHandling.Error });
			}
			catch (JsonReaderException jsonReaderException)
			{
				Console.WriteLine("Exception thrown: " + jsonReaderException.Message);
			}

		}
	}
}
