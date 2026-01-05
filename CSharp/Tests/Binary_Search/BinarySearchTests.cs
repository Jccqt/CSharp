using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.BinarySearch;
using Xunit;

namespace CSharp.Tests.Binary_Search
{
    public class BinarySearchTests
    {
        [Fact]
        public void ElementExistSearch()
        {
            // Arrange
            var solver = new BinarySearch();

            // Act
            var result = solver.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void ElementNotExistSearch()
        {
            // Arrange
            var solver = new BinarySearch();

            // Act
            var result = solver.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);

            // Assert
            Assert.Equal(-1, result);
        }
    }
}
