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
    public class StringTrimerTests
    {
        [TestMethod()]
        public void SplitNumeralsTest()
        {
            var test = "012--345---678-99485379--------------354345";
            var actual = new List<string>()
            {
                "012",
                "345",
                "67899485379",
                "354345"
            };

            var result = StringTrimer.SplitNumerals(test).ToList();

            Assert.AreEqual(result.Count(), actual.Count());

            for (int i = 0; i < result.Count(); i++)
            {
                Assert.AreEqual(result[i], actual[i]);
            }

        }

        [TestMethod()]
        public void SplitCommaNumeralsTest()
        {
            var test = "012--345---678,9948,537,9--------354345";
            var actual = new List<string>()
            {
                "012",
                "345",
                "67899485379",
                "354345"
            };

            var result = StringTrimer.SplitCommaNumerals(test).ToList();

            Assert.AreEqual(result.Count(), actual.Count());

            for (int i = 0; i < result.Count(); i++)
            {
                Assert.AreEqual(result[i], actual[i]);
            }

        }
    }
}