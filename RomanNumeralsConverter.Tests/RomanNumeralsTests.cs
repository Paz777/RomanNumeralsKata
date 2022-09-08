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

        [Test]
        public void Given_A_Roman_Numerals_ConvertToNumber_Should_Return_A_Valid_Number()
        {
            romanNumerals.ConvertToNumber("I").Should().Be(1);
        }
    }
}

