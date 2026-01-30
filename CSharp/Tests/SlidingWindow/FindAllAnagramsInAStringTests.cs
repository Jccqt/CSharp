using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.SlidingWindow;

namespace CSharp.Tests.SlidingWindow
{
    public class FindAllAnagramsInAStringTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new FindAllAnagramsInAString();

            // Act
            var result = solver.FindAnagrams("cbaebabacd", "abc");

            // Assert
            Assert.Equal([0, 6], result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new FindAllAnagramsInAString();

            // Act
            var result = solver.FindAnagrams("abab", "ab");

            // Assert
            Assert.Equal([0, 1, 2], result);
        }
    }
}
