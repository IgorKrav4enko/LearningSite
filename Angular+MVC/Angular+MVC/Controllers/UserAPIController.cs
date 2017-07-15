using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular_MVC.DBContext;

namespace Angular_MVC.Controllers
{
    public class UserAPIController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(DB.Users.AsEnumerable());
        }

        public HttpResponseMessage Post([FromBody]User value)
        {
            DB.Users.Add(value);
            return ToJson(DB.SaveChanges());
        }

        public HttpResponseMessage Put(int id, [FromBody]User value)
        {
            DB.Entry(value).State = EntityState.Modified;
            return ToJson(DB.SaveChanges());
        }
        public HttpResponseMessage Delete(int id)
        {
            DB.Users.Remove(DB.Users.FirstOrDefault(x => x.Id == id));
            return ToJson(DB.SaveChanges());
        }
    }
}
