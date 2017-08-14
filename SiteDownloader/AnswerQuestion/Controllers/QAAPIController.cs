using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AnswerQuestion.Models;

namespace AnswerQuestion.Controllers
{
    public class QAAPIController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(DB.QAs.AsEnumerable());
        }

        public HttpResponseMessage Post([FromBody]QA value)
        {
            DB.QAs.Add(value);
            return ToJson(DB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]QA value)
        {
            DB.Entry(value).State = EntityState.Modified;
            return ToJson(DB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            DB.QAs.Remove(DB.QAs.FirstOrDefault(x => x.Id == id));
            return ToJson(DB.SaveChanges());
        }
    }
}
