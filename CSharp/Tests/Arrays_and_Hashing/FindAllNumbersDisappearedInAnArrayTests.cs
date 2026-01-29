using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class FindAllNumbersDisappearedInAnArrayTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new FindAllNumbersDisappearedInAnArray();

            // Act
            var result = solver.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            // Assert
            Assert.Equal([5, 6], result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new FindAllNumbersDisappearedInAnArray();

            // Act
            var result = solver.FindDisappearedNumbers(new int[] { 1, 1, });

            // Assert
            Assert.Equal([2], result);
        }
    }
}
