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
        public void Given_A_Roman_Numeral_ConvertToNumber_Should_Return_A_Valid_Number(string romanNumber, int expectedNumber)
        {
            romanNumerals.ConvertToNumber(romanNumber).Should().Be(expectedNumber);
        }

        [TestCase(1, "I")]
        public void Given_A_Number_ConvertToRomanNumeral_Should_Return_A_Valid_RomanNumeral(int number, string expectedRomanNumeral)
        {
            romanNumerals.ConvertToRomanNumeral(number).Should().Be(expectedRomanNumeral);
        }
    }
}

