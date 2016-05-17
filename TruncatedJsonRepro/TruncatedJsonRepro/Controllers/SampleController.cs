using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

using Newtonsoft.Json;

using TruncatedJsonRepro.Models;
using TruncatedJsonRepro.Properties;

namespace TruncatedJsonRepro.Controllers
{
	public class SampleController : ApiController
	{
		// GET api/<controller>
		public async Task<HttpResponseMessage> Get()
		{
			// REPRO's JSON truncation
			await Task.Delay(100);
			string myString = Resources.MyJson;
			RootObject myRootObject = JsonConvert.DeserializeObject<RootObject>(myString);
			Task.Delay(1000);
			return Request.CreateResponse(HttpStatusCode.Created, myRootObject, new JsonMediaTypeFormatter());
		}
		
		// POST api/<controller>
		public async Task<HttpResponseMessage> Post()
		{
			// DOES NOT REPRO JSON truncation
			string myString = Resources.MyJson;
			await Task.Delay(100);
			RootObject myRootObject = JsonConvert.DeserializeObject<RootObject>(myString);
			string returnedString = JsonConvert.SerializeObject(myRootObject);
			return new HttpResponseMessage(HttpStatusCode.Created)
			{
				Content = new StringContent(returnedString)
			};
		}
	}
}