using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Drawing;

namespace winClienteCamera2
{
	class Camera
	{
		static HttpClient client = new HttpClient();

		//PUT HERE YOUR IP ADDRESS CAMERA & PORT
		static String uriBasic = "http://999.999.999.999:8080";

		static String uriSetSubscribe = "/SetSubscribe";
		//static String uriUnsubscribe = "";
		static String uriGetPullMessages = "/GetPullMessages";
		//static String uriSetRenew = "";

		public respSetSubscribe respSetSub = new respSetSubscribe();

		public string strSetSubscribe;
		public string strCurrentTime;
		public string strTerminationTime;
		//public string strTimeOut;

		public string strImage;
		public string strPlateNumber;


		private Params p = new Params();

		public Camera()
		{

		}

		public void SetHttpClient()
		{
			client.BaseAddress = new Uri(uriBasic);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(
			   new MediaTypeWithQualityHeaderValue("application/xml"));

			//PUT HERE USER & PASSWORD for the Camera 
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes("user:password");
			string val = System.Convert.ToBase64String(plainTextBytes);
			client.DefaultRequestHeaders.Add("Authorization", "Basic " + val);

		}

		public async Task<String> RunSetSubscribe()
		{
			
			//string content = string.Empty;
			var content = new StringContent(p.getXMLSetSubscribe(), Encoding.UTF8, "application/xml"); ;
			try
			{
				HttpResponseMessage response = await client.PostAsync(uriSetSubscribe, content);
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();


				string strSearch = body.ToString();

				//Server
				string toFind1 = "[CDATA[";
				string toFind2 = "]]></server";
				int start = strSearch.IndexOf(toFind1) + toFind1.Length;
				int end = strSearch.IndexOf(toFind2, start);
				strSetSubscribe = strSearch.Substring(start, end - start);

				//CurrentTime
				toFind1 = "<currentTime";
				toFind2 = "</currentTime>";
				start = strSearch.IndexOf(toFind1) + toFind1.Length + 15;
				end = strSearch.IndexOf(toFind2, start);
				strCurrentTime = strSearch.Substring(start, end - start);

				//TerminationTime
				toFind1 = "<terminationTime";
				toFind2 = "</terminationTime>";
				start = strSearch.IndexOf(toFind1) + toFind1.Length + 15;
				end = strSearch.IndexOf(toFind2, start);
				strTerminationTime = strSearch.Substring(start, end - start);


				return body.ToString() + "\n\r";
			}
			catch (Exception ex)
			{
				return "{\"errorMessages\":[\"" + ex.Message + "\"],\"errors\":{}}";
			}

		}

		public async Task<String> RunGetMessages()
		{

			string val = p.getXMLGetMessages().Replace("auxServer", strSetSubscribe.Trim());

			var content = new StringContent(val, Encoding.UTF8, "application/xml"); ;
			try
			{
				HttpResponseMessage response = await client.PostAsync(uriGetPullMessages, content);
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();

				string strSearch = body.ToString();


				//String Image
				string toFind1 = "<targetBase64Data type=";
				string toFind2 = "]]></targetBase64Data>";
				int start = strSearch.LastIndexOf(toFind1) + toFind1.Length+18;
				int end = strSearch.LastIndexOf(toFind2); //, start);
				strImage = strSearch.Substring(start, end - start);

				//Plate Number
				toFind1 = "<plateNumber type=";
				toFind2 = "</plateNumber>";
				start = strSearch.LastIndexOf(toFind1) + toFind1.Length + 9;
				end = strSearch.LastIndexOf(toFind2);//, start);
				strPlateNumber = strSearch.Substring(start, end - start);

				return body.ToString() + "\n\r";
			}
			catch (HttpRequestException hex)
			{
				return "{\"errorMessages\":[\"" + hex.Message + "\"],\"errors\":{}}";
			}
			catch (Exception ex)
			{
				return "{\"errorMessages\":[\"" + ex.Message + "\"],\"errors\":{}}";
			}
		}

		public Bitmap getBitmapFromString(String ImageText)
		{
			Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(ImageText));
			System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
			Bitmap bitImage = new Bitmap((Bitmap)Image.FromStream(streamBitmap));

			return bitImage;
		}

		public string FixBase64ForImage(string Image)
		{
			System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);
			sbText.Replace("\r\n", String.Empty); sbText.Replace(" ", String.Empty);
			return sbText.ToString();
		}

	}
}
