using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CrimeSystemFactory
    {
        public static IScraper ScrapeService(string type, CrimeMediator mediator)
        {
            IScraper service = null;
            switch (type)
            {
                case "Polisen.se":
                    service = new PoliceScraper(mediator);
                    break;
                case "Utryckning.se":
                    service = new UtryckningScraper(mediator);
                    break;
                default:
                    return null;
            }

            return service;
        }
    }
}
