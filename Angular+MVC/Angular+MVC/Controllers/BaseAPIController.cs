using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Angular_MVC.DBContext;
using Newtonsoft.Json;

namespace Angular_MVC.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected readonly LearningSiteEntities DB = new LearningSiteEntities();
        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            //response.Content = new StringContent(JsonConvert.SerializeObject(obj, Formatting.None,
            //    new JsonSerializerSettings()
            //    {
            //        ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            //    }), Encoding.UTF8, "application/json");
          
            return response;
        }
    }
}
