using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
//Console.WriteLine(JsonConvert.SerializeObject(Incoming,Formatting.Indented));
namespace LEI
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter source filename (without extension): ");
				string Filename = Console.ReadLine();
				string AllLEINumbers = Input.Input.ReadCSV(Filename + ".csv");
				if (AllLEINumbers != null)
				{
					var Incoming = APICaller.Fetch(AllLEINumbers);
					if (Incoming != null)
					{
						string OutputFile = Filename + "Output.csv";
						int Result = Output.Output.WriteCSV(OutputFile, Incoming);
						if (Result == 1)
							Console.WriteLine("Successfully written in " + OutputFile);
						else
							Console.WriteLine("Error while writing the file " + OutputFile);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("ERROR: " + e.Message);
			}
			Console.WriteLine();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
