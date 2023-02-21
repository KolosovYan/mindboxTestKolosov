using MindBoxTestKolosov;
namespace MindBoxTestKolosov.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTriangleArea()
        {
            //arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle testTriangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6.0;

            //act
            double actualArea = testTriangle.CalculateArea();

            //assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CheckTriangleIsRectangular()
        {
            //arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            bool expected = true;

            //act
            Triangle TestTriangle = new Triangle(sideA, sideB, sideC);
            bool actual = TestTriangle.CheckTriangleIsRectangular();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCircleArea()
        {
            //arrange
            double radius = 6.0;
            Circle testCircle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(6, 2);

            //act
            double actualArea = testCircle.CalculateArea();

            //assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}