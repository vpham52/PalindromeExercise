using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("racecar", true)]
        [InlineData("mOm", true)]
        [InlineData("kayak", true)]
        [InlineData("hi", false)]
        [InlineData("pullup", true)]
        [InlineData("computer", false)]
        [InlineData("heLLO", false)]
        [InlineData("Victoria", false)]

        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var pTest = new WordSmith();

            //Act
            var actual = pTest.IsAPalindrome(word);

            //Arrange
            Assert.Equal(expected, actual);
        }


        
    }
}
