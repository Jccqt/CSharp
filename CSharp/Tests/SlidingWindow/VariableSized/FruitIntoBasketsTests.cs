using CSharp.Problems.SlidingWindow.VariableSized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.SlidingWindow.VariableSized
{
    public class FruitIntoBasketsTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new FruitIntoBaskets();

            // Act
            var result = solver.TotalFruit([1, 2, 1]);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new FruitIntoBaskets();

            // Act
            var result = solver.TotalFruit([0, 1, 2, 2]);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new FruitIntoBaskets();

            // Act
            var result = solver.TotalFruit([1, 2, 3, 2, 2]);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
