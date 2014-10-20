using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace ClassLib
{
    public abstract class CrimeScraperSystem : IScraper
    {
        public virtual string URL { get; set; }
        public virtual string XPATH { get; set; }
        public virtual string NewsSiteName { get; set; }

        public CrimeMediator mediator;
        public void ReadTopCrime()
        {
            var getHtmlWeb = new HtmlWeb();
            var document = getHtmlWeb.Load(URL);
            string newsheadline = String.Empty;

            var nodes = document.DocumentNode.SelectNodes(XPATH);

            foreach (var title in nodes)
            {
                newsheadline = title.InnerText;
            }

            this.mediator.FoundCrime(NewsSiteName, newsheadline);
        }


    }


}
