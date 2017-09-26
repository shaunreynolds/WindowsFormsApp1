using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
namespace RolandUnitest
{
    [TestClass]
    public class RolandTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            myClass test = new myClass();

            test.add(5);
            test.add(0);



        }
    }
}
