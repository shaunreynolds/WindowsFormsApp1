using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShaunsClass()
        {
            StringManipulation sm = new StringManipulation();

            String test = "lowercase";

            String output = sm.toUpperCase(test);

            bool isUpper = sm.isUpper(output);

            Assert.IsTrue(isUpper);
        }
    }
}
