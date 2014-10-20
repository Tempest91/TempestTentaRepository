using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace ClassLib
{
    public abstract class ScraperSystem : IScraper
    {
        public virtual string URL { get; set; }
        public virtual string XPATH { get; set; }
        public virtual string NewsName { get; set; }
        public string FoundCrime(string Title)
        {
            var getHtmlWeb = new HtmlWeb();
            string orgName = string.Empty;

             document = getHtmlWeb.Load(String.Format(URL, Title.Replace("-", "")));

            var nodes = document.DocumentNode.SelectNodes(XPATH);
            foreach (var name in nodes)
            {
                orgName = "Från " + NewsName + " " + name.InnerText;
            }

            return orgName;
        }

      
    }


}
