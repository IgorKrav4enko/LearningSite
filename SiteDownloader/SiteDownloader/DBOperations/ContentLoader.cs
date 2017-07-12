using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SiteDownloader.DBOperations
{
    class ContentLoader
    {
        private readonly StringBuilder sb = new StringBuilder();
        private readonly IWebDriver driver = new ChromeDriver();

        // selenium web driver has no TryFindElement
        private bool IsElementPresent(IWebElement node, By locatorKEy) // TODO make like TryGetValue
        {
            try
            {
                node.FindElement(locatorKEy);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        // TODO delete Thread.Sleep

        private string SaveImage(IWebElement node)
        {
            var src = node.GetAttribute("src");
            var imgName = Path.GetFileName(src);
            Actions action = new Actions(driver);
            action.ContextClick(node).Build().Perform();
            SendKeys.SendWait("v");
            Thread.Sleep(3000);
            SendKeys.SendWait(@"{Enter}");
            return imgName;
        }

        private static string[] MadeCloseTag(params string[] tags)
        {
            return tags.Select(x => x.Insert(1, "/")).ToArray();
        }
        private string CreateString(string text, params string[] typesOfNode)
        {
            var openTags = string.Join("", typesOfNode);
            var closeTags = string.Join("", MadeCloseTag(typesOfNode));
            var resultString = string.Format("{0}{1}{2}", openTags, text, closeTags);
            resultString += Environment.NewLine;
            return resultString;
        }

        public void GetMetanitContent()
        {
            //var site = DB.Sites.Where(si => si.SiteName == "Angular 2").FirstOrDefault();
            //site.Cours.Add(new Cour()
            //{ CourseName = "Angular" });
            driver.Navigate().GoToUrl("https://metanit.com/web/angular2/1.1.php");
            // get all lesson's links
            var links = driver.FindElements(By.CssSelector("#browser > li > ul > li > span > a"));
            var hrefs = links.Select(l => l.GetAttribute("href")).ToList();

            foreach (var href in hrefs)
            {
                driver.Navigate().GoToUrl(hrefs[4]);
                // get content node
                var mainContent = driver.FindElements(By.Id("articleText")).FirstOrDefault();
                //get all child nodes
                var nodes = mainContent.FindElements(By.XPath("*"));
                //get child nodes content
                foreach (var node in nodes)
                {
                    if (node.TagName == "h1")
                    {

                    }
                    if (node.TagName == "h4")
                    {
                        sb.AppendLine(CreateString(node.Text, "<h4>"));
                    }
                    else if (node.TagName == "p")
                    {
                        sb.AppendLine(CreateString(node.Text, "<p>"));
                    }
                    else if (node.TagName == "div")
                    {
                        if (IsElementPresent(node, By.CssSelector("td.code")))
                        {
                            var code = node.FindElement(By.CssSelector("td.code"));
                            sb.AppendLine(CreateString(code.Text, "<pre>", "<code>"));

                        }
                        else if (IsElementPresent(node, By.ClassName("consoletext")))
                        {
                            sb.AppendLine(CreateString(node.Text, "<pre>"));
                        }
                    }
                    else if (node.TagName == "img")
                    {
                        var imgName = SaveImage(node);
                        sb.AppendLine(CreateString(imgName, "<img>"));
                    }
                    else if (node.TagName == "ul")
                    {
                        var listItems = node.FindElements(By.TagName("li"));
                        var listItemsString = string.Join(Environment.NewLine, listItems.Select(x => CreateString(x.Text, "<li>")).ToArray());
                        //listItems.Select(x => CreateString(x.Text, "<li>")).ToArray();
                        sb.AppendLine(CreateString(listItemsString, "<ul>"));
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
