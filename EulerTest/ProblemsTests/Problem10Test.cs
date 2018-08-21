using Euler.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTest
{
    [TestClass]
    public class Problem10Test
    {
        [TestMethod]
        public void TestIs3Prime()
        {
            int primeCandidate = 3;
            Problem10 problem10 = new Problem10();
            bool isPrime = problem10.isPrime(primeCandidate);
            Assert.AreEqual(true, isPrime);
        }
        [TestMethod]
        public void TestIs7Prime()
        {
            int primeCandidate = 7;
            Problem10 problem10 = new Problem10();
            bool isPrime = problem10.isPrime(primeCandidate);
            Assert.AreEqual(true, isPrime);

        }
        [TestMethod]
        public void TestIs8Prime()
        {
            int primeCandidate = 8;
            Problem10 problem10 = new Problem10();
            bool isPrime = problem10.isPrime(primeCandidate);
            Assert.AreEqual(false, isPrime);

        }

        [TestMethod]
        public void TestSumOfPrimesBelow10()
        {
            int max = 10;
            Problem10 problem10 = new Problem10();
            long sum = problem10.findSumOfNaturalsUnder(max);
            Assert.AreEqual(17L, sum);
        }
    }
}
