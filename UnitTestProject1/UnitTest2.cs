using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
             Class1 obj = new Class1();
             long actual = obj.CountFactorial(1);

             Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Class1 obj = new Class1();
            long actual = obj.CountFactorial(5);

            Assert.AreEqual(120, actual);
        }

    }
}
