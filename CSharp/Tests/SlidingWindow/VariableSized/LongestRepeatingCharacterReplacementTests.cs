using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class LongestRepeatingCharacterReplacementTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new LongestRepeatingCharacterReplacement();

            // Act
            var result = solver.CharacterReplacement("ABAB", 2);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new LongestRepeatingCharacterReplacement();

            // Act
            var result = solver.CharacterReplacement("AABABBA", 1);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
