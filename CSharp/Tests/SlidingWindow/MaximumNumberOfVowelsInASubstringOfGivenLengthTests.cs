using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;

namespace CSharp.Tests.SlidingWindow
{
    public class MaximumNumberOfVowelsInASubstringOfGivenLengthTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MaximumNumberOfVowelsInASubstringOfGivenLength();

            // Act
            var result = solver.MaxVowels("abciiidef", 3);

            // Assert
            Assert.Equal(3, result);    
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MaximumNumberOfVowelsInASubstringOfGivenLength();

            // Act
            var result = solver.MaxVowels("aeiou", 2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new MaximumNumberOfVowelsInASubstringOfGivenLength();

            // Act
            var result = solver.MaxVowels("leetcode", 3);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
