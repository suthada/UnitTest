using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

namespace LABUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Assingment_1()
        {
            AssingmentClass assigmentClass = new AssingmentClass();
            int input = 33;

            string result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("F", result);
        }

        [TestMethod]
        public void Test_Assignment_2()
        {
            AssingmentClass assingmentClass = new AssingmentClass();
            double result = assingmentClass.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            result = assingmentClass.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);
            result = assingmentClass.getDistance(-3, -2, -7, -8); 
            Assert.AreEqual(7.21, result);
            result = assingmentClass.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);

        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            AssingmentClass assingmentClass = new AssingmentClass();
            int result = assingmentClass.getFactorial(5);
            Assert.AreEqual(120,result);
        }

        [TestMethod]
        public void Test_Assignment_4()
        {
            AssingmentClass assingmentClass = new AssingmentClass();
            bool password = assingmentClass.CheckPassword("abc12345");
            Assert.AreEqual("True", password);
            password = assingmentClass.CheckPassword("abc123");
            Assert.AreEqual("False", password);
            password = assingmentClass.CheckPassword("abcdefgh");
            Assert.AreEqual("False", password);
            password = assingmentClass.CheckPassword("12345678");
            Assert.AreEqual("False", password);
        }
    }
}