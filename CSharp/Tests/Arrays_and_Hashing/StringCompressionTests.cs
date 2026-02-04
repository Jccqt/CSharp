using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class StringCompressionTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new StringCompression();

            // Act
            var result = solver.Compress(['a', 'a', 'b', 'b', 'c', 'c', 'c']);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new StringCompression();

            // Act
            var result = solver.Compress(['a']);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new StringCompression();

            // Act
            var result = solver.Compress(['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
