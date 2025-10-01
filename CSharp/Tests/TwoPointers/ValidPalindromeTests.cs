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
            var solver = new ValidPalindrome();
            var result = solver.IsPalindrome("A man, a plan, a canal: Panama");

            Assert.True(result);
        }

        [Fact]
        public void InvalidPalindrome()
        {
            var solver = new ValidPalindrome();
            var result = solver.IsPalindrome("race a car");

            Assert.False(result);
        }

        [Fact]
        public void NoTextPalindrome()
        {
            var solver = new ValidPalindrome();
            var result = solver.IsPalindrome(" ");

            Assert.True(result);
        }
    }
}
