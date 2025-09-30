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
            var solver = new ValidParentheses();
            var result = solver.IsValidParentheses("([])");

            Assert.True(result);
        }

        [Fact]
        public void InvalidParentheses()
        {
            var solver = new ValidParentheses();
            var result = solver.IsValidParentheses("([)]");

            Assert.False(result);
        }
    }
}
