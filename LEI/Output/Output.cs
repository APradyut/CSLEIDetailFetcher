using System.Collections.Generic;
using LEI.CSVHandler;
using System.IO;

namespace LEI.Output
{
	public class Output
	{
		private static void CreateHeaders(string FileName)
		{
			CsvRow SingleRow = new CsvRow();
			SingleRow.Add("LEI Number");
			SingleRow.Add("Registration Status");
			SingleRow.Add("Legal Name");
			SingleRow.Add("Entity Status");
			SingleRow.Add("Next Renewal Date");
			using (CsvFileWriter writer = new CsvFileWriter(FileName))
			{
				writer.WriteRow(SingleRow);
			}
		}
		/// <returns>
		/// 1 - Successful
		/// 0 - Unsuccessful
		/// </returns>
		public static int WriteCSV(string FileName, List<Models.Class1> Data)
		{
			try
			{
				CreateHeaders(FileName);
				List<string> Rows = new List<string>();
				foreach (Models.Class1 SingleData in Data)
				{
					string SingleRow = "";
					SingleRow += SingleData.LEI.i + ",";
					SingleRow += SingleData.Registration.RegistrationStatus.i + ",";
					SingleRow += SingleData.Entity.LegalName.i + ",";
					SingleRow += SingleData.Entity.EntityStatus.i + ",";
					SingleRow += SingleData.Registration.NextRenewalDate.i + ",";
					SingleRow += "\n";
					Rows.Add(SingleRow);
				}
				File.AppendAllLines(FileName, Rows);
				return 1;
			}
			catch
			{
				return 0;
			}
		}
	}
}
