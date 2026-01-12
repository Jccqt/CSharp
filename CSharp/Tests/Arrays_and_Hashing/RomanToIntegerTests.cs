using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new RomanToInteger();

            // Act
            var result = solver.RomanToInt("III");

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new RomanToInteger();

            // Act
            var result = solver.RomanToInt("LVIII");

            // Assert
            Assert.Equal(58, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new RomanToInteger();

            // Act
            var result = solver.RomanToInt("MCMXCIV");

            // Assert
            Assert.Equal(1994, result);
        }
    }
}
