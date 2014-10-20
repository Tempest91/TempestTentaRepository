using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;


namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
  
        [TestMethod]
        public void TestMethodPolisenHeadline()
        {
            CrimeMediator test = new CrimeMediator();
            IScraper testScraper = CrimeSystemFactory.ScrapeService("Polisen.se", test);
            testScraper.ReadTopCrime();
            Assert.IsNotNull(test.newsHeadline);
        }
        public void TestMethodUtryckningHeadLine()
        {
            CrimeMediator test = new CrimeMediator();
            IScraper testScraper = CrimeSystemFactory.ScrapeService("Utryckning.se", test);
            testScraper.ReadTopCrime();
            Assert.IsNotNull(test.newsHeadline);
        }
    }
}
