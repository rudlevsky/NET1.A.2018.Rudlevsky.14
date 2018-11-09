using System;
using System.Text;
using FibonachiGenerator;
using NUnit.Framework;

namespace Generation.Tests
{
    [TestFixture]
    public class GeneratorTests
    {
        [TestCase(1, ExpectedResult = "0")]
        [TestCase(5, ExpectedResult = "0 1 1 2 3")]
        [TestCase(10, ExpectedResult = "0 1 1 2 3 5 8 13 21 34")]
        public string GenerateFibonachi_NumberCount_FibonachiNumbers(int count)
        {
            var builder = new StringBuilder();

            foreach (var item in Generator.GenerateFibonachi(count))
            {
                builder.Append(item + " ");
            }

            return builder.Remove(builder.Length - 1, 1).ToString();
        }

        [Test]
        public void GenerateFibonachi_NumberCountZero_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Generator.GenerateFibonachi(0));
        }

        [Test]
        public void GenerateFibonachi_NumberCountBelowZero_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Generator.GenerateFibonachi(-1));
        }
    }
}
