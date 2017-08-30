using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_2_and_1_should_be_3()
        {
            sumStringsShouldBe("3", "2", "1");
        }

        [TestMethod]
        public void input_10_and_10_should_be_20()
        {
            sumStringsShouldBe("20", "10", "10");
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
            var achars = a.Reverse().ToList();
            var bchars = b.Reverse().ToList();
            var result = new List<double>();
            for (int i = 0; i < achars.Count; i++)
            {
                result.Add(char.GetNumericValue(achars[i]) + char.GetNumericValue(bchars[i]));
            }

            result.Reverse();
            return string.Concat(result);
        }
    }
}
