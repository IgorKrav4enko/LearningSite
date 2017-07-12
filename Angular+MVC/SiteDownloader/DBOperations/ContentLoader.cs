using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SiteDownloader.DBContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SiteDownloader.DBOperations
{
    internal class ContentLoader
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private readonly IWebDriver _driver = new ChromeDriver();
        private readonly LearningSiteEntities _db = new LearningSiteEntities();

        public void GetMetenitImages()
        {
            _driver.Navigate().GoToUrl("https://metanit.com/web/angular2/1.1.php");
            // get all lesson's links
            var links = _driver.FindElements(By.CssSelector("#browser > li > ul > li > span > a"));
            var hrefs = links.Select(l => l.GetAttribute("href")).ToList();

            foreach (var href in hrefs)
            {
                _driver.Navigate().GoToUrl(href);
                // get content node
                var mainContent = _driver.FindElements(By.Id("articleText")).FirstOrDefault();
                //get all child nodes
                var nodes = mainContent?.FindElements(By.XPath("*"));
                //get child nodes content
                if (nodes != null)
                    foreach (var node in nodes)
                    {
                        if (node.TagName == "img")
                        {
                            SaveImage(node);
                        }

                    }
            }
            _driver.Close();
        }

        public void GetMetanitContent()
        {
            _driver.Navigate().GoToUrl("https://metanit.com/web/angular2/1.1.php");
            // get all lesson's links
            var links = _driver.FindElements(By.CssSelector("#browser > li > ul > li > span > a"));
            var hrefs = links.Select(l => l.GetAttribute("href")).ToList();
            var lesson = new Lesson();
            var subLesson = new SubLesson();
            var lessonList = new List<Lesson>();

            foreach (var href in hrefs)
            {
                _driver.Navigate().GoToUrl(href);
                // get content node
                var mainContent = _driver.FindElements(By.Id("articleText")).FirstOrDefault();
                //get all child nodes
                var nodes = mainContent?.FindElements(By.XPath("*"));
                //get child nodes content
                if (nodes != null)
                    foreach (var node in nodes)
                    {
                        if (node.TagName == "h1")
                        {
                            lesson = new Lesson()
                            {
                                Name = node.Text,
                                CourseId = _db.Courses.FirstOrDefault(x => x.CourseName == "Руководство по Angular")?.Id
                            };
                        }
                        else if (node.TagName == "h2" || node.TagName == "h3")
                        {
                            subLesson = new SubLesson()
                            {
                                Name = node.Text,
                                LessonId = lesson.Id
                            };
                        }
                        else if (node.TagName == "h4")
                        {
                            _sb.AppendLine(CreateString(node.Text, "<h4>"));
                        }
                        else if (node.TagName == "p")
                        {
                            _sb.AppendLine(CreateString(node.Text, "<p>"));
                        }
                        else if (node.TagName == "div")
                        {
                            if (IsElementPresent(node, By.CssSelector("td.code")))
                            {
                                var code = node.FindElement(By.CssSelector("td.code"));
                                _sb.AppendLine(CreateString(code.Text, "<pre>", "<code>"));
                            }
                            else if (IsElementPresent(node, By.ClassName("consoletext")))
                            {
                                _sb.AppendLine(CreateString(node.Text, "<pre>"));
                            }
                        }
                        else if (node.TagName == "img")
                        {
                            var src = node.GetAttribute("src");
                            var imgName = Path.GetFileName(src);
                            _sb.AppendLine(CreateString(imgName, "<img>"));
                        }
                        else if (node.TagName == "ul")
                        {
                            var listItems = node.FindElements(By.TagName("li"));
                            var listItemsString = string.Join(Environment.NewLine,
                                listItems.Select(x => CreateString(x.Text, "<li>")).ToArray());
                            _sb.AppendLine(CreateString(listItemsString, "<ul>"));
                        }
                    }
                subLesson.Content = _sb.ToString();
                _sb.Clear();
                lesson.SubLessons.Add(subLesson);
                if (!lessonList.Select(x => x.Name).Contains(lesson.Name))
                {
                    lessonList.Add(lesson);
                }
            }
            var lessonsConext = _db.Courses.FirstOrDefault(x => x.CourseName == "Руководство по Angular")?.Lessons;
            foreach (var lesson1 in lessonList)
            {
                lessonsConext?.Add(lesson1);
            }
            _db.SaveChanges();
            _driver.Close();
        }
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

        private void SaveImage(IWebElement node)
        {
            var action = new Actions(_driver);
            action.ContextClick(node).Build().Perform();
            SendKeys.SendWait("v");
            Thread.Sleep(2000);
            SendKeys.SendWait(@"{Enter}");
        }

        private static string[] MakeCloseTag(params string[] tags)
        {
            return tags.Select(x => x.Insert(1, "/")).ToArray();
        }

        private string CreateString(string text, params string[] typesOfNode)
        {
            var openTags = string.Join("", typesOfNode);
            var closeTags = string.Join("", MakeCloseTag(typesOfNode));
            var resultString = $"{openTags}{text}{closeTags}";
            resultString += Environment.NewLine;
            return resultString;
        }
    }
}
