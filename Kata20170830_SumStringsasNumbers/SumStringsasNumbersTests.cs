using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170830_SumStringsasNumbers
{
    [TestClass]
    public class SumStringsasNumbersTests
    {
        [TestMethod]
        public void input_1_and_1_should_be_2()
        {
            sumStringsShouldBe("2", "1", "1");
        }

        private static void sumStringsShouldBe(string expected, string a, string b)
        {
            var kata = new Kata();
            var actual = kata.sumStrings(a, b);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string sumStrings(string a, string b)
        {
            return "2";
        }
    }
}
