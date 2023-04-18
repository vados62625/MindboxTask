namespace GFSTests
{
    [TestFixture]
    public class GFSTests
    {
        /// <summary>
        /// Testing TryGetSquare method with a string object as a first parameter
        /// </summary>
        [Test]
        public void TryGetSquareOfNonFigureObjectTest()
        {
            string s = "string";
            var success = GeometricFigureSquare.GeometricFigureSquare.TryGetSquare(s, out var result);
            Assert.That(result, Is.EqualTo(0));
            Assert.That(success, Is.EqualTo(false));
        }

        /// <summary>
        /// Testing the calculation of the square of a triangle with GetSquare method
        /// </summary>
        [Test]
        public void GetSquareOfTriangleTest()
        {
            var triangle = new Triangle(new double[] { 30, 40, 50 });
            var square = GeometricFigureSquare.GeometricFigureSquare.GetSquare(triangle);
            Assert.That(square, Is.EqualTo(600));
        }

        /// <summary>
        /// Testing the calculation of the square of a triangle with TryGetSquare method
        /// </summary>
        [Test]
        public void TryGetSquareOfTriangleTest()
        {
            var triangle = new Triangle(new double[] { 30, 40, 50 });
            var success = GeometricFigureSquare.GeometricFigureSquare.TryGetSquare(triangle, out var result);
            Assert.That(result, Is.EqualTo(600));
            Assert.That(success, Is.EqualTo(true));
        }

        /// <summary>
        /// Testing right triangle
        /// </summary>
        [Test]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(new double[] { 3, 4, 5 });
            Assert.That(triangle.IsRight, Is.EqualTo(true));
        }

        /// <summary>
        /// Testing non-right triangle
        /// </summary>
        [Test]
        public void NonRightTriangleTest()
        {
            var triangle = new Triangle(new double[] { 3, 4, 6 });
            Assert.That(triangle.IsRight, Is.EqualTo(false));
        }

        /// <summary>
        /// Testing the calculation of the square of a circle with GetSquare method
        /// </summary>
        [Test]
        public void GetSquareOfCircleTest()
        {
            var circle = new Circle(5);
            var square = GeometricFigureSquare.GeometricFigureSquare.GetSquare(circle);
            Assert.That(square, Is.EqualTo(78.53981633974483));
        }

        /// <summary>
        /// Testing the calculation of the square of a circle with TryGetSquare method
        /// </summary>
        [Test]
        public void TryGetSquareOfCircleTest()
        {
            var circle = new Circle(5);
            var success = GeometricFigureSquare.GeometricFigureSquare.TryGetSquare(circle, out var result);
            Assert.That(result, Is.EqualTo(78.53981633974483));
            Assert.That(success, Is.EqualTo(true));
        }

        /// <summary>
        /// Testing Triangle with negative and zero side values
        /// </summary>
        [TestCase(0)]
        [TestCase(-1)]
        public void TriangleNegativeAndZeroSideTest (double sideValue)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(new double[] { sideValue, 1, 1 }));
        }

        /// <summary>
        /// Testing Triangle with more or less than three sides
        /// </summary>
        [Test]
        public void TriangleWithNotTreeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(new double[] { 1, 2, 3, 4 }));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(new double[] { 1, 2 }));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(new double[] { }));
        }

        /// <summary>
        /// Testing Circle with negative and zero radius value
        /// </summary>
        [TestCase(0)]
        [TestCase(-1)]
        public void CircleNegativeAndZeroSideTest(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}