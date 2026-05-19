using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class GetEqualSubstringsWithinBudgetTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new GetEqualSubstringsWithinBudget();

            // Act
            var result = solver.EqualSubstring("abcd", "bcdf", 3);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new GetEqualSubstringsWithinBudget();

            // Act
            var result = solver.EqualSubstring("abcd", "cdef", 3);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new GetEqualSubstringsWithinBudget();

            // Act
            var result = solver.EqualSubstring("abcd", "acde", 0);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
