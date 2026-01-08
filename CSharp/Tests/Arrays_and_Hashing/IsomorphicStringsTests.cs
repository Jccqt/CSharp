using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class IsomorphicStringsTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new IsomorphicStrings();

            // Act
            var result = solver.IsIsomorphic("egg", "add");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new IsomorphicStrings();

            // Act
            var result = solver.IsIsomorphic("foo", "bar");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new IsomorphicStrings();

            // Act
            var result = solver.IsIsomorphic("paper", "title");

            // Assert
            Assert.True(result);
        }
    }
}
