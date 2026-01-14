using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class MinimumIndexSumOfTwoListsTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MinimumIndexSumOfTwoLists();

            // Act
            var result = solver.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
                new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });

            // Assert
            Assert.Equal(new string[] { "Shogun" }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MinimumIndexSumOfTwoLists();

            // Act
            var result = solver.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
                new string[] { "KFC", "Shogun", "Burger King" });

            // Assert
            Assert.Equal(new string[] { "Shogun" }, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new MinimumIndexSumOfTwoLists();

            // Act
            var result = solver.FindRestaurant(new string[] { "happy", "sad", "good" }, new string[] { "sad", "happy", "good" });

            // Assert
            Assert.Equal(new string[] { "sad", "happy" }, result);
        }
    }
}
