using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class RansomNoteTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new RansomNote();

            // Act
            var result = solver.CanConstruct("a", "b");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new RansomNote();

            // Act
            var result = solver.CanConstruct("aa", "ab");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new RansomNote();

            // Act
            var result = solver.CanConstruct("aa", "aab");

            // Assert
            Assert.True(result);
        }
    }
}
