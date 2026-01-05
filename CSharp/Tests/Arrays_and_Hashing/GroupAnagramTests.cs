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
            // Arrange
            var solver = new GroupAnagrams();

            // Act
            var result = solver.GetGroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

            // Assert
            Assert.Equal(3, result.Count);
        }
    }
}
