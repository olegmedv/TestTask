namespace FigureAreas.NUnitTests
{
    [TestFixture]
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_5_78Returned()
        {
            //arrange
            var radius = 5;
            var expected = Math.PI * Math.Pow(radius, 2);

            //act
            var circle = new Circle(radius);
            var actual = circle.CalculateArea();

            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Circle_Negative2_ArgumentExceptionReturned()
        {
            //arrange
            var radius = -2;

            //assert
            var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));

            Assert.That(ex.Message, Is.EqualTo("Radius of the circle cannot be lesser than zero."));
        }
    }
}