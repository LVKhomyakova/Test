using System;
using CodeWars;
using System.Linq;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaxSequenceTests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, Kata.MaxSequence(new int[0]));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(6, Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Enumerable.Range(-10, 100).Where(n=> n>=0).Sum(), Kata.MaxSequence(Enumerable.Range(-10,100).ToArray()));
        }

    }
}
