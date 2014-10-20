using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PoliceScraper : ScraperSystem
    {
        public override string URL
        {
            get { return "http://polisen.se/"; }
        }

        public override string XPATH
        {
            get { return "//*[@id='newslist-1']/div/ul/li[1]/p[1]/a"; }
        }
        //public override string NewsName
        //{
        //    get { return ""; }
        //}
    }
}
