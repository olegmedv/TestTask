namespace FigureAreas.NUnitTests
{
    [TestFixture]
    public class UnknownFigurePickMethodTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UnknownFigure_8_7_10Returned()
        {
            //arrange
            var countNodesBoundaries = 8;
            var countNodesInside = 7;
            var expected = 10;

            //act
            var unknownFigure = new UnknownFigurePickMethod(countNodesBoundaries, countNodesInside);
            var actual = unknownFigure.CalculateArea();

            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void UnknownFigure_Negative8_7_ArgumentExceptionReturned()
        {
            //arrange
            var countNodesBoundaries = -8;
            var countNodesInside = 7;

            //assert
            var ex = Assert.Throws<ArgumentException>(() => new UnknownFigurePickMethod(countNodesBoundaries, countNodesInside));

            Assert.That(ex.Message, Is.EqualTo("Nodes cannot be lesser or equal zero."));
        }
    }
}