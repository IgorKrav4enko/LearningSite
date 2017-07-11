using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SiteDownloader.DBContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SiteDownloader.DBOperations
{
    class CRUD
    {
        private readonly AngularEntities DB = new AngularEntities();
        public void AddSite(Site Site)
        {
            DB.Sites.Add(Site);
            DB.SaveChanges();
        }

        public void ShowSites()
        {
            Console.WriteLine(DB.Sites.Count());
        }

        public bool isElementPresent(IWebElement node, By locatorKEy)
        {
            try
            {
                node.FindElement(locatorKEy);
                return true;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        public void CreateContent()
        {

            //var site = DB.Sites.Where(si => si.SiteName == "Angular 2").FirstOrDefault();
            //site.Cours.Add(new Cour()
            //{ CourseName = "Angular" });

            StringBuilder sb = new StringBuilder();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://metanit.com/web/angular2/1.1.php");
            var links = driver.FindElements(By.CssSelector("#browser > li > ul > li > span > a"));
            var hrefs = links.Select(l => l.GetAttribute("href")).ToList();
            foreach (var href in hrefs)
            {
                driver.Navigate().GoToUrl(hrefs[0]);
                var mainContent = driver.FindElements(By.Id("articleText")).FirstOrDefault();
                var nodes = mainContent.FindElements(By.XPath("*"));
                foreach (var node in nodes)
                {
                    if (node.TagName == "p")
                    {
                        sb.AppendLine("<p>" + node.Text + "</p>");
                        sb.AppendLine();
                    }
                    if (node.TagName == "div")
                    {
                        if (isElementPresent(node, By.CssSelector("td.code")))
                        {
                            var code = node.FindElement(By.CssSelector("td.code"));
                            sb.AppendLine("<code><pre>" + code.Text + "</pre></code>");
                            sb.AppendLine();
                        }
                        if (isElementPresent(node, By.ClassName("consoletext")))
                        {
                            sb.AppendLine("<pre>" + node.Text + "</pre>");
                        }
                    }
                    if (node.TagName == "img")
                    {
                        var src = node.GetAttribute("src");
                        sb.AppendLine("<img>" + src + "</img>");
                        var imgName = Path.GetFileName(src);
                        Actions action = new Actions(driver);
                        action.ContextClick(node).Build().Perform();
                        action.SendKeys("v").Build().Perform();

                    }

                }
                var string1 = sb.ToString();
            }
            //links[0].Click();

            //driver.Navigate().GoToUrl("https://metanit.com/web/angular2/2.9.php");
            //var codeList = driver.FindElements(By.CssSelector("td.code"));
            //var codeStrings = codeList.Select(x => x.Text).ToList();
            //var s = driver.Title;
            //driver.Close();


            //Site
            //Cour
            //ParentLesson
            //Lesson
            //SubLesson
        }
    }
}
