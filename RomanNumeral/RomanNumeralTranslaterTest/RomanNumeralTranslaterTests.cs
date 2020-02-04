using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.Tests
{
    [TestClass()]
    public class RomanNumeralTranslaterTests
    {
        [TestMethod()]
        public void TranslateTest()
        {
            //Test case 1 - Mmxix = 2019 - Pass
            int result = RomanNumeralTranslater.Translate("MmxiX");
            Assert.AreEqual(result, 2019);

            //Test case 2 - MCMxix = 1919 - fail
            //int result = RomanNumeralTranslater.Translate("MCMxiX");
            //Assert.AreEqual(result, 1919);

            //Test case 3 - IP = should - fail
            //int result = RomanNumeralTranslater.Translate("IP");
            //Assert.AreEqual(result, 1);
        }
    }
}