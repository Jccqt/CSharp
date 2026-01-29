using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class HowManyNumbersAreSmallerThanTheCurrentNumberTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new HowManyNumbersAreSmallerThanTheCurrentNumber();

            // Act
            var result = solver.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });

            // Assert
            Assert.Equal(new int[] { 4, 0, 1, 1, 3 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new HowManyNumbersAreSmallerThanTheCurrentNumber();

            // Act
            var result = solver.SmallerNumbersThanCurrent(new int[] { 6, 5, 4, 8 });

            // Assert
            Assert.Equal(new int[] { 2, 1, 0, 3 }, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange 
            var solver = new HowManyNumbersAreSmallerThanTheCurrentNumber();

            // Act
            var result = solver.SmallerNumbersThanCurrent(new int[] { 7, 7, 7, 7 });

            // Assert
            Assert.Equal(new int[] { 0, 0, 0, 0 }, result);
        }
    }
}
