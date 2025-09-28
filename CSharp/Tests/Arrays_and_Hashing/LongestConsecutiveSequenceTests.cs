using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class LongestConsecutiveSequenceTests
    {
        [Fact]
        public void NonsortedArray()
        {
            var solver = new LongestConsecutiveSequence();
            var result = solver.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });

            Assert.Equal(4, result);
        }

        [Fact]
        public void SortedArray()
        {
            var solver = new LongestConsecutiveSequence();
            var result = solver.LongestConsecutive(new int[] { 1, 2, 3, 4 });

            Assert.Equal(4, result);
        }

        [Fact]
        public void OneSequenceArray()
        {
            var solver = new LongestConsecutiveSequence();
            var result = solver.LongestConsecutive(new int[] { 0, 3, 99, 21, 29 });

            Assert.Equal(1, result);
        }
    }
}
