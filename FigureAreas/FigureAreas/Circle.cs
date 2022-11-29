namespace FigureAreas
{
    public class Circle : IFigure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Validate();
        }

        public void Validate()
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Radius of the circle cannot be lesser than zero.");
            }
        }

        public double CalculateArea()
        {
            var cirleArea = Math.PI * Math.Pow(Radius, 2);
            return cirleArea;
        }
    }
}