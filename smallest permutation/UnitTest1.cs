namespace Solution
{
    using NUnit.Framework;
    using System;
    using ConsoleApp1;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void KataTest()
        {
          // Kata kata = new Kata();

            Assert.AreEqual(-20, Kata.MinPermutation(-20));
            Assert.AreEqual(-23, Kata.MinPermutation(-32));
            Assert.AreEqual(0, Kata.MinPermutation(0));
            Assert.AreEqual(10, Kata.MinPermutation(10));
            Assert.AreEqual(23499, Kata.MinPermutation(29394));
        }
    }
}
