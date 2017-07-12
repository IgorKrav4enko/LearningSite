using SiteDownloader.DBOperations;

namespace SiteDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            ContentLoader contentLoader = new ContentLoader();
            //contentLoader.GetMetanitContent();
            contentLoader.GetMetenitImages();
        }
    }
}
