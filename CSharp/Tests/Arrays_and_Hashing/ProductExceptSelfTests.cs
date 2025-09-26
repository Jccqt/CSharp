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
            var solver = new ProductExceptSelf();
            var result = solver.GetProductExceptSelf(new int[] { 1, 2, 3, 4 });

            Assert.Equal(new int[] { 24, 12, 8, 6 }, result);
        }

        [Fact]
        public void HasNegativeValues()
        {
            var solver = new ProductExceptSelf();
            var result = solver.GetProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });

            Assert.Equal(new int[] { 0, 0, 9, 0, 0 }, result);
        }
    }
}
