using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class FirstUniqueCharacterInAStringTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new FirstUniqueCharacterInAString();

            // Act
            var result = solver.FirstUniqChar("leetcode");

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new FirstUniqueCharacterInAString();

            // Act
            var result = solver.FirstUniqChar("loveleetcode");

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new FirstUniqueCharacterInAString();

            // Act
            var result = solver.FirstUniqChar("aabb");

            // Assert
            Assert.Equal(-1, result);
        }
    }
}
