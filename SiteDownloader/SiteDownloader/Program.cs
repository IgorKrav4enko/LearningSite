using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SiteDownloader.DBContext;
using SiteDownloader.DBOperations;

namespace SiteDownloader
{
    class Program
    {
        private static AngularEntities DB = new AngularEntities();

        public static void Main(string[] args)
        {
            //ArraySort();
            //OpenBrowser();

            Cour angular = new Cour() { CourseName = "Руководство по Angular", SiteId = DB.Sites.FirstOrDefault(x=>x.SiteName== "Angular 2").Id };
            DB.Cours.Add(angular);
            DB.SaveChanges();
            Console.Read();
        }

        public static void OpenBrowser()
        {
            // CRUD operations = new CRUD();
            ContentLoader loader = new ContentLoader();
            loader.GetMetanitContent();
            Site site = new Site() { SiteName = "Angular" };
            //operations.AddSite(site);
            //operations.CreateContent();

            //DB.Sites.Add(new Site() { SiteName = "Angular 2" });
            //DB.SaveChanges();

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://metanit.com/web/angular2/1.1.php");
            //var links = driver.FindElements(By.CssSelector("#browser > li > ul > li > span > a"));
            //var hrefs =links.Select(l => l.GetAttribute("href")).ToList();
            //foreach (var href in hrefs)
            //{

            //    driver.Navigate().GoToUrl(href);
            //}
            //links[0].Click();

            //driver.Navigate().GoToUrl("https://metanit.com/web/angular2/2.9.php");
            //var codeList = driver.FindElements(By.CssSelector("td.code"));
            //var codeStrings = codeList.Select(x => x.Text).ToList();
            //var s = driver.Title;
            //driver.Close();
        }

        public static void ArraySort()
        {
            var distinctArray = new[] { 1 };

            for (int i = 0; i < distinctArray.Length; i++)
            {
                if (!(i + 2 >= distinctArray.Length))
                {
                    if (distinctArray[i] + 1 == distinctArray[i + 1] && distinctArray[i] + 2 == distinctArray[i + 2])
                    {
                        Console.Write(distinctArray[i] + " - ");
                        for (int j = i; j < distinctArray.Length; j++)
                        {
                            if (!(j + 1 >= distinctArray.Length))
                            {
                                if (distinctArray[j] + 1 != distinctArray[j + 1])
                                {
                                    Console.Write(distinctArray[j] + " ");
                                    i = j;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Write(distinctArray[i] + " ");
                    }
                }

            }

            Console.Read();
        }

        public static void ShowArray(IEnumerable<int> array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int[] PrepareArray()
        {
            Random a = new Random();
            int[] myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = a.Next(1, 100);
            }

            ShowArray(myArray);

            Array.Sort(myArray);

            ShowArray(myArray);

            var distinctArray = myArray.Distinct().ToArray();

            ShowArray(distinctArray);

            return distinctArray;
        }


    }
}
