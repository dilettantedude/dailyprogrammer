using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace DailyProgrammerTests
{
    [TestClass]
    public class E218_Palindromic_Tests
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance;}
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void Test_1_IsPalindrome()
        {
            Tuple<bool, int> result = DailyProgrammer.PalindromicNumbers.IsPalindromic(1);

            Assert.IsTrue(result.Item1);
            Assert.IsTrue(result.Item2 < 1000);
        }

        [TestMethod]
        public void Test_28_IsPalindrom()
        {
            Tuple<bool, int> result = DailyProgrammer.PalindromicNumbers.IsPalindromic(28);            
            Assert.IsTrue(result.Item1);
            Assert.IsTrue(result.Item2 < 1000);
        }

        [TestMethod]
        public void Test_All_Under_10000()
        {
            for (long i = 0; i < 10000; i++)
            {
                Tuple<bool, int> result = DailyProgrammer.PalindromicNumbers.IsPalindromic(i);
                if (result.Item1)
                {
                    TestContext.WriteLine(String.Format("Palindromic: {0}; Count: {1}", i, result.Item2));
                }
                else
                {
                    TestContext.WriteLine(String.Format("Not Palindromic: {0}; Count: {1}", i, result.Item2));
                }
            }
        }
    }
}
