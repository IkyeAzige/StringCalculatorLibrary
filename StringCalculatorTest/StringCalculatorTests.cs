

using Moq;
using StringCalculatorLibrary;
using Xunit;

namespace StringCalculatorTest
{
    
    public class StringCalculatorTests 
    {
        private Mock<IConsole> _mockConsole;

        private Mock<IConsole> MockConsole
        {
            get
            {
                if (_mockConsole == null)
                {
                    _mockConsole = new Mock<IConsole>();
                }

                return _mockConsole;
            }
        }

        private StringCalculator StringCalculator
        {
            get
            {
                return new StringCalculator(MockConsole.Object, new SubStringDelimiterParser());
            }
        }

        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            Assert.Equal(0, StringCalculator.Add(""));
        }

        [Fact]
        public void Add_SingleNumber_ReturnsTheNumber()
        {
            Assert.Equal(1, StringCalculator.Add("1"));
        }

        [Fact]
        public void Add_MultipleNumbers_ReturnsTheSumOfNumbers()
        {
            Assert.Equal(3, StringCalculator.Add("1,2"));
            Assert.Equal(6, StringCalculator.Add("1,2,3"));
        }

        [Fact]
        public void Add_NumbersWithNewLineDelimiter_ReturnsTheSumOfNumbers()
        {
            Assert.Equal(6, StringCalculator.Add("1\n2,3"));
        }

        [Fact]
        public void Add_NewLineDelimiter_ReturnsZero()
        {
            Assert.Equal(0, StringCalculator.Add("\n"));
        }

        [Fact]
        public void Add_WithNumberGreaterThan1000_IgnoresNumber()
        {
            Assert.Equal(2, StringCalculator.Add("2,1001"));
        }

        [Fact]
        public void Add_WithMultiCharCustomDelimiter_ReturnsTheSum()
        {
            Assert.Equal(6, StringCalculator.Add("//[***]\n1***2***3"));
        }

        [Fact]
        public void Add_WithMultipleCustomDelimiter_ReturnsTheSum()
        {
            Assert.Equal(6, StringCalculator.Add("//[*][%]\n1*2%3"));
        }

        [Fact]
        public void Add_WithMultipleCustomDelimitersMultipleChar_ReturnsTheSum()
        {
            Assert.Equal(6, StringCalculator.Add("//[**][%%]\n1**2%%3"));
        }

        [Fact]
        public void Add_SingleNumber_ReturnsSameNumber()
        {
            var stringCalculator = new StringCalculator();

            var actual = stringCalculator.Add("0");

            Assert.Equal(0, actual);
        }
    }
}
