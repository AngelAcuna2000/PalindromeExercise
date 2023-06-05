using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("racecar", true)]
        [InlineData("race", false)]

        public void PalindomeTester(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
