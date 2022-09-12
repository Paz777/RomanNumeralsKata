using System;
using NUnit.Framework;
using FluentAssertions;

namespace RomanNumeralsConverter.Tests
{
    public class RomanNumeralsTests
    {
        private RomanNumerals romanNumerals;

        [SetUp]
        public void SetUp()
        {
            romanNumerals = new RomanNumerals();
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("XLII", 42)]
        [TestCase("MMXIII", 2013)]
        [TestCase("MXI", 1011)]
        [TestCase("MCDXCIX", 1499)]
        [TestCase("MMXXII", 2022)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("CX", 110)]
        [TestCase("CCCLXXV", 375)]
        [TestCase("MD", 1500)]
        [TestCase("MDLXXV", 1575)]
        [TestCase("MDCL", 1650)]
        [TestCase("MDCCXXV", 1725)]
        [TestCase("MDCCC", 1800)]
        [TestCase("MDCCCLXXV", 1875)]
        [TestCase("MCML", 1950)]
        [TestCase("MMXXV", 2025)]
        [TestCase("MMC", 2100)]
        [TestCase("MMCLXXV", 2175)]
        [TestCase("MMCCL", 2250)]
        [TestCase("MMCCCXXV", 2325)]
        [TestCase("MMCD", 2400)]
        [TestCase("MMCDLXXV", 2475)]
        [TestCase("MMDL", 2550)]
        [TestCase("MMMMMMMM", 8000)]
        [TestCase("MMMMMMMMIV", 8004)]
        public void Given_A_Roman_Numeral_ConvertToNumber_Should_Return_A_Valid_Number(string romanNumeral, int expectedNumber)
        {
            romanNumerals.ConvertToNumber(romanNumeral).Should().Be(expectedNumber);
        }

        [TestCase("IIII")]
        [TestCase("CCCC")]
        [TestCase("VV")]
        [TestCase("IC")]
        [TestCase("IM")]
        [TestCase("XM")]
        [TestCase("IL")]
        [TestCase("MCDXCXI")]
        [TestCase("MCDDXC")]
        public void TranslateRomanNumeral_WhenInvalidNumeralSemantics_RaiseException(string invalidRomanNumeral)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => romanNumerals.ConvertToNumber(invalidRomanNumeral));
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(42, "XLII")]
        [TestCase(2013, "MMXIII")]
        [TestCase(1011, "MXI")]
        [TestCase(1499, "MCDXCIX")]
        [TestCase(2022, "MMXXII")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(110, "CX")]
        [TestCase(375, "CCCLXXV")]
        [TestCase(1500, "MD")]
        [TestCase(1575, "MDLXXV")]
        [TestCase(1650, "MDCL")]
        [TestCase(1725, "MDCCXXV")]
        [TestCase(1800, "MDCCC")]
        [TestCase(1875, "MDCCCLXXV")]
        [TestCase(1950, "MCML")]
        [TestCase(2025, "MMXXV")]
        [TestCase(2100, "MMC")]
        [TestCase(2175, "MMCLXXV")]
        [TestCase(2250, "MMCCL")]
        [TestCase(2325, "MMCCCXXV")]
        [TestCase(2400, "MMCD")]
        [TestCase(2475, "MMCDLXXV")]
        [TestCase(2550, "MMDL")]
        [TestCase(8000, "MMMMMMMM")]
        [TestCase(8004, "MMMMMMMMIV")]
        public void Given_A_Number_ConvertToRomanNumeral_Should_Return_A_Valid_RomanNumeral(int number, string expectedRomanNumeral)
        {
            romanNumerals.ConvertToRomanNumeral(number).Should().Be(expectedRomanNumeral);
        }
    }
}

