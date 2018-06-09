using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LEI.CSVHandler;
using System.Threading.Tasks;

namespace LEI.Input
{
	internal class Input
	{
		public static string ReadCSV(string Filename)
		{
			string LEINumbers = "";
			try
			{
				using (CsvFileReader reader = new CsvFileReader(Filename))
				{
					CsvRow row = new CsvRow();
					while (reader.ReadRow(row))
					{
						LEINumbers += row[0] + ",";
					}
				}
				return LEINumbers;
			}
			catch (Exception)
			{
				Console.WriteLine("File is not available or is not accessible!");
				return null;
			}
		}
	}
}
