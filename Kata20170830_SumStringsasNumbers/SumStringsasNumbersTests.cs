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

        [TestMethod]
        public void input_10_and_100_should_be_110()
        {
            sumStringsShouldBe("110", "10", "100");
        }

        [TestMethod]
        public void input_16_and_125_should_be_141()
        {
            sumStringsShouldBe("141", "16", "125");
        }

        [TestMethod]
        public void input_99_and_1_should_be_100()
        {
            sumStringsShouldBe("100", "99", "1");
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
            return string.Concat(SumOfTwoChars(achars, bchars).Reverse());
        }

        private static IEnumerable<double> SumOfTwoChars(List<char> achars, List<char> bchars)
        {
            var maxCharsLength = Math.Max(achars.Count, bchars.Count);
            var tenNum = 0;
            for (var i = 0; i < maxCharsLength; i++)
            {
                var sumOf2Num = CharsNumberBy(i, achars) + CharsNumberBy(i, bchars) + tenNum;
                if (sumOf2Num >= 10)
                {
                    tenNum = sumOf2Num / 10;
                    sumOf2Num = sumOf2Num % 10;
                }
                else
                {
                    tenNum = 0;
                }

                yield return sumOf2Num;
            }

            if (tenNum != 0)
            {
                yield return tenNum;
            }
        }

        private static int CharsNumberBy(int i, List<char> achars)
        {
            return i >= achars.Count ? 0 : (int)char.GetNumericValue(achars[i]);
        }
    }
}
