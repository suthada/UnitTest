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
            int input = 1020;
            string result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("A", result);
            /*result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("B+", result);
            result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("B", result);
            result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("C+", result);
            result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("C", result);
            result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("D+", result);
            result = assigmentClass.greadCalculate(input);
            Assert.AreEqual("D", result);*/
            result = assigmentClass.greadCalculate(-1);
            Assert.AreEqual("F", result);
        }

        [TestMethod]
        public void Test_Assignment_2()
        {
            AssingmentClass assingmentClass = new AssingmentClass();
            double result = assingmentClass.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            /*result = assingmentClass.getDistance(-3, 2, 7, 8);
            Assert.AreEqual(14.14, result);
            result = assingmentClass.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);
            result = assingmentClass.getDistance(3, -2, 7, 8);
            Assert.AreEqual(14.14, result);*/

        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            AssingmentClass assingmentClass = new AssingmentClass();
            int result = assingmentClass.getFactorial(5);
            Assert.AreEqual(120,result);
        }
    }
}
