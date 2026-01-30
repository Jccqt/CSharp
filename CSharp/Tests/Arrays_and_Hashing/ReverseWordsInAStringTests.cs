using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class ReverseWordsInAStringTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ReverseWordsInAString();

            // Act
            var result = solver.ReverseWords("the sky is blue");

            // Assert
            Assert.Equal("blue is sky the", result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ReverseWordsInAString();

            // Act
            var result = solver.ReverseWords("  hello world  ");

            // Assert
            Assert.Equal("world hello", result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new ReverseWordsInAString();

            // Act
            var result = solver.ReverseWords("a good   example");

            // Assert
            Assert.Equal("example good a", result);
        }
    }
}
