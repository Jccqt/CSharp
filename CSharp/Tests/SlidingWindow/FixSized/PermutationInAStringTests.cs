using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;
using CSharp.Problems.SlidingWindow.FixSized;

namespace CSharp.Tests.SlidingWindow.FixSized
{
    public class PermutationInAStringTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new PermutationInAString();

            // Act
            var result = solver.CheckInclusion("ab", "eidbaooo");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new PermutationInAString();

            // Act
            var result = solver.CheckInclusion("ab", "eidboaoo");

            // Assert
            Assert.False(result);
        }
    }
}
