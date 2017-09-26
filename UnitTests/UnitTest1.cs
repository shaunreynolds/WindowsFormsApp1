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

        [TestMethod]
        public void TestShaunsClass2()
        {
            StringManipulation sm = new StringManipulation();
            String shouldFail = "notALLupperCASE";
            String shouldPass = "ALLUPPERCASE";

            Assert.IsFalse(sm.isUpper(shouldFail));
            Assert.IsTrue(sm.isUpper(shouldPass));
        }
    }
}
