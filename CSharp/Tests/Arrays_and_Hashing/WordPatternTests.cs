using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class WordPatternTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new WordPattern();

            // Act
            var result = solver.IsWordPattern("abba", "dog cat cat dog");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new WordPattern();

            // Act
            var result = solver.IsWordPattern("abba", "dog cat cat fish");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new WordPattern();

            // Act
            var result = solver.IsWordPattern("aaaa", "dog cat cat dog");

            // Assert
            Assert.False(result);
        }
    }
}
