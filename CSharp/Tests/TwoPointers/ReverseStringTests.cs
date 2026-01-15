using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class ReverseStringTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ReverseString();
            char[] arr = new char[] { 'h', 'e', 'l', 'l', 'o' };

            // Act
            solver.ReverseStringArray(arr);

            // Assert
            Assert.Equal(new char[] { 'o', 'l', 'l', 'e', 'h' }, arr);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ReverseString();
            char[] arr = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };

            // Act
            solver.ReverseStringArray(arr);

            // Assert
            Assert.Equal(new char[] { 'h', 'a', 'n', 'n', 'a', 'H' }, arr);
        }
    }
}
