using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using AnswerQuestion.DAL;
using Newtonsoft.Json;

namespace AnswerQuestion.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected readonly AnsweQuestionContext DB = new AnsweQuestionContext();
        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
