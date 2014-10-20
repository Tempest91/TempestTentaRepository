using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CrimeSystemFactory
    {
        public static IScraper ScrapeService(string type)
        {
            IScraper service = null;
            switch (type)
            {
                case "Polisen.se":
                    service = new PoliceScraper();
                    break;
                case "Utryckning.se":
                    service = new UtryckningScraper();
                    break;
                default:
                    return null;
            }

            return service;
        }
    }
}
