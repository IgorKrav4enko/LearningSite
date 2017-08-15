using OpenQA.Selenium;
using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;


namespace QuestionLoader
{
    class Program
    {

        static void Main(string[] args)
        {
            Loader loader = new Loader();
            //loader.Get2();

            Console.Read();
        }


    }

    class Loader
    {

        public void Get()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://job-interview.ru/questions/dotnet/");
            var a = _driver.FindElement(By.TagName("h2"));
            //a.Click();
            //var container =_driver.FindElement(By.CssSelector("#b-parser > div:nth-child(1)"));
            //var q = container.FindElement(By.TagName("b")).Text;
        }

        public void Get1()
        {

            string a = "";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://job-interview.ru/questions/dotnet/");
            for (int i = 87; i <= 102; i++)
            {
                try
                {
                    var tag = document.DocumentNode.SelectSingleNode($"//*[@id='q_{i}']");
                    a += "<Question>" + tag.InnerText + "\n";
                    a += "<Answer>" + tag.NextSibling.NextSibling.InnerText + "\n";
                }
                catch
                {
                    
                }
                
                
            }

            
        }
        
    }

}

