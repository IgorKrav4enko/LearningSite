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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

      
    }
}
