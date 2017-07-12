using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular_MVC.Controllers
{
    public class LessonController : BaseAPIController
    {

        public HttpResponseMessage Get()
        {
            return ToJson(UserDB.Users.AsEnumerable());
        }
    }
}
