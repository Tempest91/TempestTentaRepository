using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CrimeMediator
    {
        private IScraper Scraper;
        public string newsHeadline { get; set; }

        internal void RegisterMyScraper(IScraper Scraper)
        {
            this.Scraper = Scraper;
        }

        public void FoundCrime(string site, string title)
        {
            newsHeadline = title;
            Console.WriteLine("Från" + site + title);
        }

    }
}
