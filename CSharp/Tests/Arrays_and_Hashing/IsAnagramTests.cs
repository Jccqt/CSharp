using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class IsAnagramTests
    {
        [Fact]
        public void ValidAnagram()
        {
            // Arrange
            var solver = new IsAnagram();

            // Act
            var result = solver.CheckIsAnagram("anagram", "nagaram");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void InvalidAnagram()
        {
            // Arrange
            var solver = new IsAnagram();

            // Act
            var result = solver.CheckIsAnagram("rat", "car");

            // Assert
            Assert.False(result);
        }
    }
}
