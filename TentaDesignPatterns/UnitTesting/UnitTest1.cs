using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPolisen()
        {
            var testSystem = new ScraperSystem();
            PoliceScraper test = new PoliceScraper(testSystem);
        }
        public void TestMethodUpplysning()
        {
            var test = new UpplysningScraper();
        }
    }
}
