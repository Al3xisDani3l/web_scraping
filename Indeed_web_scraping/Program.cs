using System;
using HtmlAgilityPack;

namespace Indeed_web_scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            string testUrl = "https://mx.indeed.com/jobs?q=software&l=Ciudad+Ju%C3%A1rez%2C+Chih.";

            HtmlWeb web = new HtmlWeb();

            HtmlDocument document = web.Load(testUrl);






            Console.WriteLine("Hello World!");
        }
    }


    public class JobInformation
    {
        public string JobTitle { get; set; }
    }

}
