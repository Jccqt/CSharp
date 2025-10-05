using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class GroupAnagramTests
    {
        [Fact]
        public void GroupAnagram()
        {
            var solver = new GroupAnagrams();
            var result = solver.GetGroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            Assert.Equal(3, result.Count);
        }
    }
}
