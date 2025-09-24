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
        public void SingleCase()
        {
            var solver = new ContainsDuplicate();
            var result = solver.CheckContainsDuplicate(new int[] { 1, 2, 3, 1 });

            Assert.True(result);
        }
    }
}
