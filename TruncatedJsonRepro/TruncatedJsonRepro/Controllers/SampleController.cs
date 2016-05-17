using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

using Newtonsoft.Json;

using TruncatedJsonRepro.Models;
using TruncatedJsonRepro.Properties;

namespace TruncatedJsonRepro.Controllers
{
	public class SampleController : ApiController
	{
		// GET api/<controller>
		public HttpResponseMessage Get()
		{
			// REPRO's JSON truncation
			string myString = Resources.MyJson;
			RootObject myRootObject = JsonConvert.DeserializeObject<RootObject>(myString);
			return Request.CreateResponse(HttpStatusCode.Created, myRootObject, new JsonMediaTypeFormatter());
		}
		
		// POST api/<controller>
		public HttpResponseMessage Post()
		{
			// DOES NOT REPRO JSON truncation
			string myString = Resources.MyJson;
			RootObject myRootObject = JsonConvert.DeserializeObject<RootObject>(myString);
			string returnedString = JsonConvert.SerializeObject(myRootObject);
			return new HttpResponseMessage(HttpStatusCode.Created)
			{
				Content = new StringContent(returnedString)
			};
		}
	}
}