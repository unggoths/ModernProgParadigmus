using MpP;

namespace UnitTestForLab1
{
    public class UnitTest1
    {
        [Fact]
        public void TestTwoSolutions()
        {
            var result = LinearResolve.SolveQuadratic(1, -5, 6);
            Assert.Equal("x1 = 3, x2 = 2", result);
        }

        [Fact]
        public void TestOneSolution()
        {
            var result = LinearResolve.SolveQuadratic(1, -6, 9);
            Assert.Equal("x = 3", result);
        }

        [Fact]
        public void TestInfiniteSolutions()
        {
            var result = LinearResolve.SolveQuadratic(0, 0, 0);
            Assert.Equal(QuadraticFunctionExistingResults.InfiniteSolutions, result);
        }

        [Fact]
        public void TestNoSolution()
        {
            var result = LinearResolve.SolveQuadratic(0, 0, 5);
            Assert.Equal(QuadraticFunctionExistingResults.NoSolution, result);
        }
    }
}
