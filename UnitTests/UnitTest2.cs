using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            BradClass k = new BradClass();

            int result = k.add(5, 5);

            Assert.AreEqual(result, 10);

            try
            {
                k.add(int.Parse("A"), int.Parse("B"));
                Assert.Fail("Should have thrown format exeption");
            }
            catch(FormatException e)
            {
                Debug.WriteLine(e);
            }

        }
    }
}
