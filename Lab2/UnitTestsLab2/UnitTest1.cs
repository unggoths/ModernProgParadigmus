using Lab2;

namespace UnitTestsLab2
{
    public class UnitTest1
    {
        public class GeometryCalculationTests
        {
            [Fact]
            public void GetCircleArea_WithRadiusFiveReturnsCorrectValue()
            {
                
                double radius = 5;
                double expectedArea = 78.539816;

                double actualArea = ShapeCalculator.GetCircleArea(radius);

                Assert.Equal(expectedArea, actualArea, precision: 5);
            }

            [Fact]
            public void GetCirclePerimeterWithRadiusFiveReturnsCorrectValue()
            {
                double radius = 5;
                double expectedPerimeter = 31.415926;

                double actualPerimeter = ShapeCalculator.GetCirclePerimeter(radius);

                Assert.Equal(expectedPerimeter, actualPerimeter, precision: 5);
            }


            [Fact]
            public void GetRectangleAreaWithFourAndSixReturnsTwentyFour()
            {
                double sideA = 4;
                double sideB = 6;
                double expectedArea = 24;

                double actualArea = ShapeCalculator.GetRectangleArea(sideA, sideB);

                Assert.Equal(expectedArea, actualArea);
            }

            [Fact]
            public void GetRectanglePerimeterWithFourAndSixReturnsTwenty()
            {
                double sideA = 4;
                double sideB = 6;
                double expectedPerimeter = 20;

                double actualPerimeter = ShapeCalculator.GetRectanglePerimeter(sideA, sideB);

                Assert.Equal(expectedPerimeter, actualPerimeter);
            }


            [Fact]
            public void GetEquilateralTriangleAreaWithSideTenReturnsCorrectValue()
            {
                double side = 10;
                double expectedArea = 43.30127;

                double actualArea = ShapeCalculator.GetEquilateralTriangleArea(side);

                Assert.Equal(expectedArea, actualArea, precision: 5);
            }

            [Fact]
            public void GetEquilateralTrianglePerimeterWithSideTenReturnsThirty()
            {
                double side = 10;
                double expectedPerimeter = 30;

                double actualPerimeter = ShapeCalculator.GetEquilateralTrianglePerimeter(side);

                Assert.Equal(expectedPerimeter, actualPerimeter);
            }


            [Fact]
            public void ReadShapesWhenFileNotFoundReturnsEmptyList()
            {
                string nonExistentPath = "missingFileTest.csv";

                var result = ShapeCsvReader.ReadShapes(nonExistentPath);

                Assert.NotNull(result);
                Assert.Empty(result);
            }
        }
    }
}
