using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new LongestSubstringWithoutRepeatingCharacters();

            // Act
            var result = solver.LengthOfLongestSubstring("abcabcbb");

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new LongestSubstringWithoutRepeatingCharacters();

            // Act
            var result = solver.LengthOfLongestSubstring("bbbbb");

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new LongestSubstringWithoutRepeatingCharacters();

            // Act
            var result = solver.LengthOfLongestSubstring("pwwkew");

            // Assert
            Assert.Equal(3, result);
        }
    }
}
