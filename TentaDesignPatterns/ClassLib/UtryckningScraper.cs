using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
    public class UtryckningScraper : CrimeScraperSystem
    {
        public UtryckningScraper (CrimeMediator mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterMyScraper(this);
        }
        public override string URL
        {
            get { return "http://orebrotribune.se/utryckning-se/"; }
        }

        public override string XPATH
        {
              get { return "//*[@id='homepage']/div[1]/div[1]/h1"; }
        }
        public override string NewsSiteName
        {
            get { return "Utryckning.se"; }
        }
    }
}
