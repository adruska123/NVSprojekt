using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using A1NVSnoncore;

namespace UnitTesty
{
    /// <summary>
    /// Unittest, ktorý kontroluje rozsah generovania
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int min = 0, max = 5;
            RandomNumber cislo = new RandomNumber();
            int testCislo = cislo.RandomInt(min, max);
            bool jeVRozsahu = false;
            if (testCislo <= max && testCislo >= min)
                jeVRozsahu = true;
            Assert.AreEqual(true, jeVRozsahu);
        }
    }
}
