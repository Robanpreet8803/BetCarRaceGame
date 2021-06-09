using System;
using BetCarRaceGame.RaceEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BetGameTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactory()
        {
            Punter punter = Factory.GetPunter("Alex");
            bool result = punter is Alex;
            Assert.AreEqual(result, true);
        }
    }
}
