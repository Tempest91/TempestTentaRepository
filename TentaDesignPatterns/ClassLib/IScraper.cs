using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public interface IScraper
    {
        string FoundCrime(string Title);
        //Task<string> FoundCrimeasync(string Title);
    }
}
