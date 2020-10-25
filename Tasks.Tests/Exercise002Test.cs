using Xunit;
using TechReturners.Tasks;
using System.Collections.Generic;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks.UnitTests
{
    public class Exercise002Test
    {
        [Fact]
        public void CheckPast()
        {
            Assert.Equal(61000, Exercise002.Past(0, 1, 1));
            Assert.Equal(3661000, Exercise002.Past(0, 1, 1));
            Assert.Equal(0, Exercise002.Past(0, 0, 0));
            Assert.Equal(3601000, Exercise002.Past(1, 0, 1));
            Assert.Equal(3600000, Exercise002.Past(1, 0, 0));
        }
    }
}