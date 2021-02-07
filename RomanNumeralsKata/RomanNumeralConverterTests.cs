using Xunit;
using System;
namespace RomanNumeralsKata
{
    public class RomanNumeralConverterTests
    {
        [Fact]
        public void zeroReturnsEmpty()
        {
            string numeral = RomanNumeralConverter.convertInt(0);
            Assert.Equal("", numeral);
        }
        [Fact]
        public void negativeReturnsError()
        {

            Assert.Throws<Exception>(() => RomanNumeralConverter.convertInt(-1));
        }
        [Fact]
        public void over9999ThrowsError()
        {
            Assert.Throws<Exception>(() => RomanNumeralConverter.convertInt(10000));            
        }
        [Fact]
        public void oneReturnsI()
        {
            int input = 1;
            string actual = RomanNumeralConverter.convertInt(input);
            string expected = "I";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void threeReturnsIII()
        {
            int input = 3;
            string actual = RomanNumeralConverter.convertInt(input);
            string expected = "III";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void fiveReturnsV()
        {
            int input = 5;
            string actual = RomanNumeralConverter.convertInt(input);
            string expected = "V";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void fourReturnsIV()
        {
            int input = 4;
            string actual = RomanNumeralConverter.convertInt(input);
            string expected = "IV";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void sixReturnsVI()
        {
            Assert.Equal(
                "VI",
                RomanNumeralConverter.convertInt(6)
            );
        }

        [Fact]
        public void tenReturnsX()
        {
            Assert.Equal(
                "X",
                RomanNumeralConverter.convertInt(10)
            );
        }
        [Fact]
        public void twelveReturnsXII()
        {
            Assert.Equal(
                "XII",
                RomanNumeralConverter.convertInt(12)
            );
        }
        [Fact]
        public void fifteenReturnsXV()
        {
            Assert.Equal(
                "XV",
                RomanNumeralConverter.convertInt(15)
            );
        }

        [Fact]
        public void twentyReturnsXX()
        {
            Assert.Equal(
                "XX",
                RomanNumeralConverter.convertInt(20)
            );
        }

        [Fact]
        public void nineTeenReturnsXIX()
        {
            Assert.Equal(
                "XIX",
                RomanNumeralConverter.convertInt(19)
            );
        }

        [Fact]
        public void FortyNineReturnsXLIX()
        {
            Assert.Equal(
                "XLIX",
                RomanNumeralConverter.convertInt(49)
            );
        }

        [Fact]
        public void SeventyFourReturnsLXXIV()
        {
            Assert.Equal(
                "LXXIV",
                RomanNumeralConverter.convertInt(74)
            );
        }

        [Fact]
        public void NinetyReturnsXC()
        {
            Assert.Equal(
                "XC",
                RomanNumeralConverter.convertInt(90)
            );
        }

        [Fact]
        public void FiveHundredReturnsD()
        {
            Assert.Equal(
                "D",
                RomanNumeralConverter.convertInt(500)
            );
        }

        [Fact]
        public void OneThousandReturnsM()
        {
            Assert.Equal(
                "M",
                RomanNumeralConverter.convertInt(1000)
            );
        }
        [Fact]
        public void NineTeenNintyFourReturnsMCMXCIV()
        {
            Assert.Equal(
                "MCMXCIV",
                RomanNumeralConverter.convertInt(1994)
            );
        }
        [Fact]
        public void TwentyTwentyOneReturnsMMXXI()
        {
            Assert.Equal(
                "MMXXI",
                RomanNumeralConverter.convertInt(2021)
            );
        }
    }
}
