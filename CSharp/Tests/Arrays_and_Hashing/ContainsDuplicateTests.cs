using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class ContainsDuplicateTests
    {
        [Fact]
        public void HasDuplicate()
        {
            var solver = new ContainsDuplicate();
            var result = solver.CheckContainsDuplicate(new int[] { 1, 2, 3, 1 });

            Assert.True(result);
        }

        [Fact]
        public void HasNoDuplicate()
        {
            var solver = new ContainsDuplicate();
            var result = solver.CheckContainsDuplicate(new int[] { 1, 2, 3, 4, 5 });

            Assert.False(result);
        }
    }
}
