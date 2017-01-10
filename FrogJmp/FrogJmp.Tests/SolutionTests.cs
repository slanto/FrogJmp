using FrogJmp.Core;
using Xunit;

namespace FrogJmp.Tests
{   
    public class SolutionTests
    {
        [Theory]
        [InlineData(10, 85, 30, 3)]
        public void GetFrogJump(int x, int y, int step, int expected)
        {
            var sut = new Solution();
            int actual = sut.GetFrogJump(x, y, step);
            Assert.Equal(expected, actual);
        }
    }
}
