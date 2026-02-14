using MpP;

namespace UnitTestForLab1
{
    public class UnitTest1
    {
        [Fact]
        public void TestOneSolution()
        {
            var result = LinearResolve.SolveLinear(2, 6);
            Assert.Equal("x = 3", result);
        }

        [Fact]
        public void TestInfiniteSolutions()
        {
            var result = LinearResolve.SolveLinear(0, 0);
            Assert.Equal(ResolveResults.Intifity, result);
        }

        [Fact]
        public void TestNoSolution()
        {
            var result = LinearResolve.SolveLinear(0, 5);
            Assert.Equal(ResolveResults.NoSolution, result);
        }
    }
}
