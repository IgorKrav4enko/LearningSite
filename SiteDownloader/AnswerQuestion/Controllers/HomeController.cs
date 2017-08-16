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

            //AnsweQuestionContext a = new AnsweQuestionContext();
            //a.QAs.Add(new QA() {TechnologyType = "C#", Question = "how", Answer = "That way"});
            //a.SaveChanges();
            //ViewBag.Answer = a.QAs.ToList();
            return View();
        }

        public ActionResult About()
        {
            AnsweQuestionContext a = new AnsweQuestionContext();

            List<QA> QA = a.QAs.ToList();

            ViewBag.Message = "Your application description page.";

            return View(QA);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}