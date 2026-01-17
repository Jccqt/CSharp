using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class ReverseOnlyLettersTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ReverseOnlyLetters();

            // Act
            var result = solver.ReversesOnlyLetters("ab-cd");

            // Assert
            Assert.Equal("dc-ba", result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ReverseOnlyLetters();

            // Act
            var result = solver.ReversesOnlyLetters("a-bC-dEf-ghIj");

            // Assert
            Assert.Equal("j-Ih-gfE-dCba", result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new ReverseOnlyLetters();

            // Act
            var result = solver.ReversesOnlyLetters("Test1ng-Leet=code-Q!");

            // Assert
            Assert.Equal("Qedo1ct-eeLg=ntse-T!", result);
        }
    }
}
