using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.TwoPointers;
using Xunit;

namespace CSharp.Tests.TwoPointers
{
    public class ValidPalindromeTests
    {
        [Fact]
        public void ValidPalindrome()
        {
            // Arrange
            var solver = new ValidPalindrome();

            // Act
            var result = solver.IsPalindrome("A man, a plan, a canal: Panama");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void InvalidPalindrome()
        {
            // Arrange
            var solver = new ValidPalindrome();

            // Act
            var result = solver.IsPalindrome("race a car");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void NoTextPalindrome()
        {
            // Arrange
            var solver = new ValidPalindrome();

            // Act
            var result = solver.IsPalindrome(" ");

            // Assert
            Assert.True(result);
        }
    }
}
