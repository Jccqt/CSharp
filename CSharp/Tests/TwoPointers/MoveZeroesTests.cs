using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class MoveZeroesTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MoveZeroes();
            int[] nums = [0, 1, 0, 3, 12];

            // Act
            solver.MovingZeroes(nums);

            // Assert
            Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, nums);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MoveZeroes();
            int[] nums = [0];

            // Act
            solver.MovingZeroes(nums);

            // Assert
            Assert.Equal(new int[] {0}, nums);
        }
    }
}
