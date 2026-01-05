using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Stack;
using Xunit;

namespace CSharp.Tests.Stack
{
    public class ValidParenthesesTests
    {
        [Fact]
        public void ValidParentheses()
        {
            // Arrange
            var solver = new ValidParentheses();

            // Act
            var result = solver.IsValidParentheses("([])");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void InvalidParentheses()
        {
            // Arrange
            var solver = new ValidParentheses();

            // Act
            var result = solver.IsValidParentheses("([)]");

            // Assert
            Assert.False(result);
        }
    }
}
