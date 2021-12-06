using System.Runtime.InteropServices;
using NUnit.Framework;
using Automat;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("123", true)]
        [TestCase("1234", false)]
        [TestCase("9", true)]
        [TestCase("55", false)]
        [TestCase("13", false)]
        public void Test1(string s, bool x)
        {
            Assert.AreEqual(x, Automat.Program.Test(s));
        }
    }
}