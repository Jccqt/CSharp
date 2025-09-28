using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class IsValidSudokuTests
    {
        [Fact]
        public void ValidSudoku()
        {
            var solver = new IsValidSudoku();
            var result = solver.CheckIsValidSudoku(new char[][]
                        {
                        new char[] { '5','3','.','.','7','.','.','.','.' },
                        new char[] { '6','.','.','1','9','5','.','.','.' },
                        new char[] { '.','9','8','.','.','.','.','6','.' },
                        new char[] { '8','.','.','.','6','.','.','.','3' },
                        new char[] { '4','.','.','8','.','3','.','.','1' },
                        new char[] { '7','.','.','.','2','.','.','.','6' },
                        new char[] { '.','6','.','.','.','.','2','8','.' },
                        new char[] { '.','.','.','4','1','9','.','.','5' },
                        new char[] { '.','.','.','.','8','.','.','7','9' }
                        });
            
            Assert.True(result);
        }

        [Fact]
        public void InvalidSudoku()
        {
            var solver = new IsValidSudoku();
            var result = solver.CheckIsValidSudoku(new char[][]
                        {
                        new char[] { '8','3','.','.','7','.','.','.','.' },
                        new char[] { '6','.','.','1','9','5','.','.','.' },
                        new char[] { '.','9','8','.','.','.','.','6','.' },
                        new char[] { '8','.','.','.','6','.','.','.','3' },
                        new char[] { '4','.','.','8','.','3','.','.','1' },
                        new char[] { '7','.','.','.','2','.','.','.','6' },
                        new char[] { '.','6','.','.','.','.','2','8','.' },
                        new char[] { '.','.','.','4','1','9','.','.','5' },
                        new char[] { '.','.','.','.','8','.','.','7','9' }
                        });

            Assert.False(result);
        }
    }
}
