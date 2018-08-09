using System;
using NUnit.Framework;
using EulersOrbit;

namespace EulersOrbit.Tests
{
    [TestFixture]
    public class UnitTest1
    {

        [TestCase(9, 23)]
        [TestCase(999, 233168)]
        public void ProjectEulerQuestion1_AlwaysReturns_SumOfMuliplesOfThreeAndFiveThatAreBelowB(int b, int expectedResult)
        {
            Assert.AreEqual(Program.ProjectEulerQuestion1(b), expectedResult);
        }

        [TestCase(9, 23)]
        [TestCase(999, 233168)]
        public void ProjectEulerQuestion1a_AlwaysReturns_SumOfMuliplesOfThreeAndFiveThatAreBelowB(int b, int expectedResult)
        {
            Assert.AreEqual(Program.ProjectEulerQuestion1a(b), expectedResult);
        }

        [Test]
        public void ProjectEulerQuestion4_AlwaysReturns_LargestPalindrome()
        {
            Assert.AreEqual(Program.ProjectEulerQuestion4(), 906609);
        }

    }
}
