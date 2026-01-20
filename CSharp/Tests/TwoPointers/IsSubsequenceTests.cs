using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.TwoPointers;
using Xunit;

namespace CSharp.Tests.TwoPointers
{
    public class IsSubsequenceTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new IsSubsequence();

            // Act
            var result = solver.Subsequence("abc", "ahbgdc");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new IsSubsequence();

            // Act
            var result = solver.Subsequence("axc", "ahbgdc");

            // Assert
            Assert.False(result);
        }
    }
}
