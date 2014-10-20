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
            var test = new PoliceScraper();
        }
        public void TestMethodUpplysning()
        {
            var test = new UpplysningScraper();
        }
    }
}
