using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;
namespace LABUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMedthod_Add()
        {
            //Arrange
            MyMath myMath = new MyMath();
            //Act
            int result = myMath.Add(1, 2);
            //Assert
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void TestMedthod_Add2()
        {
            //Arrange
            MyMath myMath = new MyMath();
            //Act
            int result = myMath.Add(11, 22);
            //Assert
            Assert.AreEqual(result, 33);
        }
    }
}
