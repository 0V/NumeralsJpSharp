using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralsJpSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsJpSharp.Core.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void ArabicToKanjiTest()
        {
            Console.WriteLine(Converter.ArabicToKanji("1145141919810810810810810810810810810810810810810810810810810810810810810810810810810810"));
        }

        [TestMethod()]
        public void ArabicToKanjiSmallTest()
        {
            Console.WriteLine(Converter.ArabicToKanjiSmall("6546"));

        }

        [TestMethod()]
        public void TrimArabicToKanjiTest()
        {
            var test = "012--345---678,9948,537,9--------354345";
            var actual = new List<string>()
            {
                "十二",
                "三百四十五",
                "六百七十八億九千九百四十八万五千三百七十九",
                "三十五万四千三百四十五"
            };

            var result = Converter.TrimArabicToKanji(test).ToList();

            Assert.AreEqual(result.Count(), actual.Count());

            for (int i = 0; i < result.Count(); i++)
            {
                Assert.AreEqual(result[i], actual[i]);
            }

        }
    }
}