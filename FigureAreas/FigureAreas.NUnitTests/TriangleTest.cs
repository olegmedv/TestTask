namespace FigureAreas.NUnitTests
{
    [TestFixture]
    public class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Triangle_15_13_17_94Returned()
        {
            //arrange
            var sideA = 15;
            var sideB = 13;
            var sideC = 17;
            var expected = 93.89988;

            //act
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.CalculateArea();
            var actualRounded = Math.Round(actual, 5);

            //assert
            Assert.That(actualRounded, Is.EqualTo(expected));

        }

        [Test]
        public void Triangle_15_13_17_CheckRectangle_FalseReturned()
        {
            //arrange
            var sideA = 15;
            var sideB = 13;
            var sideC = 17;
            var expected = false;

            //act
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.CheckIsRectangular();

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Triangle_3_4_5_CheckRectangle_TrueReturned()
        {
            //arrange
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expected = true;

            //act
            var triangle = new Triangle(sideA, sideB, sideC);
            var actual = triangle.CheckIsRectangular();

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Triangle_7_10_5_Validate_NoErrorReturned()
        {
            //arrange
            var sideA = 7;
            var sideB = 10;
            var sideC = 5;

            //assert
            Assert.That(() => new Triangle(sideA, sideB, sideC), Throws.Nothing);
        }

        [Test]
        public void Triangle_1_10_12_Validate_ArgumentExceptionReturned()
        {
            //arrange
            var sideA = 1;
            var sideB = 10;
            var sideC = 12;

            //assert
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));

            Assert.That(ex.Message, Is.EqualTo("Triangle cannot exist."));
        }
    }
}