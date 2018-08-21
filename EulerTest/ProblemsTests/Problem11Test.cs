using Euler.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EulerTest
{
    [TestClass]
    public class Problem11Test
    {
        Problem11 problem11 = new Problem11();

        [TestMethod]
        public void TestConvertStringToArray()
        {

            string numbers = "08 02 22 97 38 15";
            int[,] numbers2D = problem11.ConvertStringToArray(numbers, 3, 2);
            int[,] expected2D = new int[3, 2] { { 8, 2 }, { 22, 97 }, { 38, 15 } };
            Assert.AreEqual(expected2D[2, 1], numbers2D[2, 1]);
        }

        [TestMethod]
        public void TestProductOfList()
        {
            List<int> numbers = new List<int> { 26, 63, 78, 14 };
            Assert.AreEqual(problem11.ProductOfList(numbers), 1788696);
        }

        [TestMethod]
        public void TestBiggestHorizontalProduct()
        {
            int[,] testNumbers = new int[4, 4] { { 8, 2, 1, 1 }, { 22, 97, 45, 2 }, { 38, 15, 22, 2 }, { 8, 2, 1, 1 } };
            Assert.AreEqual(192060, problem11.BiggestHorizontalProduct(testNumbers));
        }

        [TestMethod]
        public void TestBiggestVerticalProduct()
        {
            int[,] testNumbers = new int[4, 4] { { 8, 2, 1, 1 }, { 22, 97, 45, 2 }, { 38, 15, 22, 2 }, { 8, 2, 1, 1 } };
            Assert.AreEqual(53504, problem11.BiggestVerticalProduct(testNumbers));
        }

        [TestMethod]
        public void TestBiggestDigonoalProductTopToBot()
        {
            int[,] testNumbers = new int[4, 4] { { 8, 2, 1, 1 }, { 22, 97, 45, 2 }, { 38, 15, 22, 2 }, { 8, 2, 1, 1 } };
            Assert.AreEqual(17072, problem11.BiggestDigonoalProductTopToBot(testNumbers));
        }

        [TestMethod]
        public void TestBiggestDigonoalProductBotToTop()
        {
            int[,] testNumbers = new int[4, 4] { { 8, 2, 1, 1 }, { 22, 97, 45, 2 }, { 38, 15, 22, 2 }, { 8, 2, 1, 1 } };
            Assert.AreEqual(5400, problem11.BiggestDigonalProductBotToTop(testNumbers));
        }

    }
}
