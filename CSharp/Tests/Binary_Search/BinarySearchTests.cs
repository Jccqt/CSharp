﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.BinarySearch;
using Xunit;

namespace CSharp.Tests.Binary_Search
{
    public class BinarySearchTests
    {
        [Fact]
        public void ElementExistSearch()
        {
            var solver = new BinarySearch();
            var result = solver.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);

            Assert.Equal(4, result);
        }

        [Fact]
        public void ElementNotExistSearch()
        {
            var solver = new BinarySearch();
            var result = solver.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);

            Assert.Equal(-1, result);
        }
    }
}
