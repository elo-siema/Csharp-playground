using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class ConsoleApplication1Tests
    {
        [TestMethod]
        public void TestAddMethod()
        {
            // arrange
            int[] arr1 = new int[] { 1, 2, 3 };
            int expected = 6;

            // act
            int actual = ConsoleApplication1.Program.Add(arr1);

            // assert
            Assert.AreEqual(expected, actual);
        }

       

    }
}