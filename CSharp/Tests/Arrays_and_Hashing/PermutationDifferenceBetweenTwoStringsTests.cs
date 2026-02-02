using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class PermutationDifferenceBetweenTwoStringsTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new PermutationDifferenceBetweenTwoStrings();

            // Act
            var result = solver.FindPermutationDifference("abc", "bac");

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new PermutationDifferenceBetweenTwoStrings();

            // Act
            var result = solver.FindPermutationDifference("abcde", "edbac");

            // Assert
            Assert.Equal(12, result);
        }
    }
}
