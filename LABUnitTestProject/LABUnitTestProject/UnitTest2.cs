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
            result = assingmentClass.getFactorial(1);
            Assert.AreEqual(1, result);
            result = assingmentClass.getFactorial(0);
            Assert.AreEqual(1, result);
            result = assingmentClass.getFactorial(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_Assignment_4()
        {
            AssingmentClass assingmentClass = new AssingmentClass();
            string Password1 = "abc";
            int Password2 = 123;
            string Password22 = Convert.ToString(Password1);
            bool password = assingmentClass.Checkpassword(Password1, Password22);
            Assert.AreEqual(false,password);
        }
    }
}