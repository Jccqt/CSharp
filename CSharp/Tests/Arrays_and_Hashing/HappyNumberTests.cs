using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class HappyNumberTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new HappyNumber();

            // Act
            var result = solver.IsHappy(19);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new HappyNumber();

            // Act
            var result = solver.IsHappy(2);

            // Assert
            Assert.False(result);
        }
    }
}
