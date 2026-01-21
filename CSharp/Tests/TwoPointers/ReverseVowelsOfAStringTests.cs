using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.TwoPointers;
using Xunit;

namespace CSharp.Tests.TwoPointers
{
    public class ReverseVowelsOfAStringTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ReverseVowelsOfAString();

            // Act
            var result = solver.ReverseVowels("IceCreAm");

            // Assert
            Assert.Equal("AceCreIm", result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ReverseVowelsOfAString();

            // Act
            var result = solver.ReverseVowels("leetcode");

            // Assert
            Assert.Equal("leotcede", result);
        }
    }
}
