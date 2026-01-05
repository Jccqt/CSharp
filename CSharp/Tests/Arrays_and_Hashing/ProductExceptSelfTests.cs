using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class ProductExceptSelfTests
    {
        [Fact]
        public void OnlyPositiveValues()
        {
            // Arrange
            var solver = new ProductExceptSelf();

            // Act
            var result = solver.GetProductExceptSelf(new int[] { 1, 2, 3, 4 });

            // Assertt
            Assert.Equal(new int[] { 24, 12, 8, 6 }, result);
        }

        [Fact]
        public void HasNegativeValues()
        {
            // Arrange
            var solver = new ProductExceptSelf();

            // Act
            var result = solver.GetProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });

            // Assert
            Assert.Equal(new int[] { 0, 0, 9, 0, 0 }, result);
        }
    }
}
