using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Math_and_Geometry;

namespace CSharp.Tests.Math_and_Geometry
{
    public class GreatestCommonDivisorOfStringsTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new GreatestCommonDivisorOfStrings();

            // Act
            var result = solver.GcdOfStrings("ABCABC", "ABC");

            // Assert
            Assert.Equal("ABC", result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new GreatestCommonDivisorOfStrings();

            // Act
            var result = solver.GcdOfStrings("ABABAB", "AB");

            // Assert
            Assert.Equal("AB", result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new GreatestCommonDivisorOfStrings();

            // Act
            var result = solver.GcdOfStrings("LEET", "CODE");

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void Example4()
        {
            // Arrange
            var solver = new GreatestCommonDivisorOfStrings();

            // Act
            var result = solver.GcdOfStrings("AAAAAB", "AAA");

            // Assert
            Assert.Equal("", result);
        }
    }
}
