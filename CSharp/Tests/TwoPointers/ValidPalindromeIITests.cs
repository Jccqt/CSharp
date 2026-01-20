using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.TwoPointers;
using Xunit;

namespace CSharp.Tests.TwoPointers
{
    public class ValidPalindromeIITests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ValidPalindromeII();

            // Act
            var result = solver.ValidPalindrome("aba");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ValidPalindromeII();

            // Act
            var result = solver.ValidPalindrome("abca");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new ValidPalindromeII();

            // Act
            var result = solver.ValidPalindrome("abc");

            // Assert
            Assert.False(result);
        }
    }
}
