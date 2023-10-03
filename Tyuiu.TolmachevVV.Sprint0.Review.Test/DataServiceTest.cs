using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint0.Review.Lib;

namespace Tyuiu.TolmachevVV.Sprint0.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(45, DataService.Calc(2, 3, 4));
        }
    }
}
