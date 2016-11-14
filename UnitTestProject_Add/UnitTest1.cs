using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo_Add;


namespace UnitTestProject_Add
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumResultAreEqual()
        {
            MathClass objMath = new MathClass();
            Assert.AreEqual(24, objMath.Sum(12, 12));
        }
        // Test Case#2: to verify if passed ints are Not returning Right Result 
        [TestMethod]
        public void TestSumResultAreNotEqual()
        {
            MathClass objMath = new MathClass();
            Assert.AreNotEqual(24, objMath.Sum(12, 12));
        }
        // Test Case#3: to verify if passed ints are actually Zero 
        [TestMethod]
        public void TestSumThrowExceptionWhenZero()
        {
            MathClass objMath = new MathClass();
            try
            {
                objMath.Sum(0, 0);
            }
            catch (ArgumentException)
            {
                // logging code will go here
            }
        }
        // Test Case#4: to verify if passed ints are actually Negative

        [TestMethod]
        public void TestSumThrowExceptionWhenNegative()
        {
            MathClass objMath = new MathClass();
            try
            {
                objMath.Sum(-123, -456);
            }
            catch (ArgumentException)
            {
                // logging code will go here
            }
        }
    }
}
