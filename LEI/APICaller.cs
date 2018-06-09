using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LEI
{
	public class APICaller
	{
		public static List<Models.Class1> Fetch(string LEINumber)
		{
			string URLPath = "https://leilookup.gleif.org/api/v2/leirecords?lei=" + LEINumber;
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			List<Models.Class1> Incoming = null;
			string response = "";
			try
			{
				response = client.GetStringAsync(URLPath).Result;
			}
			catch (Exception)
			{
				Console.WriteLine("Please check your Internet connection!");
				return null;
			}
			response = response.Replace('$', 'i');
			response = response.Replace("xml:lang", "xmllang");
			try
			{
				if (response != null)
				{
					Incoming = JsonConvert.DeserializeObject<List<Models.Class1>>(response);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Please contact the admin! Error code 100");	//Model invalid error
			}
			return Incoming;
		}
	}
}
