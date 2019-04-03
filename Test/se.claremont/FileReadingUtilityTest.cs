//using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_tdd.se.claremont.util;
using System.Linq;
using NUnit.Framework;

namespace Test.se.claremont
{
    [TestFixture]
    public class FileReadingUtilityTest
    {
        [Test]
        public void readFile()
        {
            FileReadingUtility readFile = new FileReadingUtility();

            Assert.AreEqual(2, readFile.readFileLinesFromResources("cars.txt").Count());
        }
    }
}
