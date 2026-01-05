using CSharp.Problems.Arrays_and_Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class MajorityElementTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MajorityElement();

            // Act
            var result = solver.GetMajorityElement(new int[] { 3, 2, 3 });

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MajorityElement();

            // Act
            var result = solver.GetMajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });

            // Assert
            Assert.Equal(2, result);
        }
    }
}
