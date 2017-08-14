using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnswerQuestion.DAL;
using AnswerQuestion.Models;

namespace AnswerQuestion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            AnsweQuestionContext a = new AnsweQuestionContext();
            ViewBag.Answer = a.QAs.First().Answer;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}