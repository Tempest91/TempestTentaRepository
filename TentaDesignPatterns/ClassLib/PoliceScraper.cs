using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PoliceScraper : CrimeMediatorSystem
    {

        public PoliceScraper(CrimeMediatorSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterMyScraper(this);
        }
        public  string URL
        {
            get { return "http://polisen.se/"; }
        }

        public override string XPATH
        {
            get { return "//*[@id='newslist-1']/div/ul/li[1]/p[1]/a"; }
        }
        public override string NewsSiteName
        {
            get { return "Polisen.se"; }
        }

    }
}
