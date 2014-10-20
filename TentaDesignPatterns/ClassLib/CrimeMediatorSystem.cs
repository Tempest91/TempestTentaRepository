using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CrimeMediatorSystem
    {
        private IScraper _Iscraper;
        public string newsHeadline { get; set; }

        internal void RegisterMyScraper(IScraper _Iscraper)
        {
            this._Iscraper = _Iscraper;

        }

        public void FoundCrime(string site, string title)
        {
            newsHeadline = newsHeadline;
            Console.WriteLine("Från" + site + title);
        }

    }
}
