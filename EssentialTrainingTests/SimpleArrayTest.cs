using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstatiation()
        {
            var testIntances = new SimpleArray();
            Assert.AreEqual(testIntances.GrocerryList.Length, 4);
            Assert.AreEqual(testIntances.GrocerryList[1], "Milk");
        }

        [TestMethod]
        public void TestToString()
        {
            var testIntances = new SimpleArray();
            Assert.IsTrue(testIntances.ToString().StartsWith("There are"));
        }
    }
}
