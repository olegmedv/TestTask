namespace FigureAreas
{
    public class Triangle : IFigure
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Validate();
        }

        public void Validate()
        {
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new ArgumentException("Triangle cannot exist.");
            }
        }

        public double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2;
            var triangleArea = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return triangleArea;
        }

        public bool CheckIsRectangular()
        {
            var listSides = new List<double>();
            listSides.Add(SideA);
            listSides.Add(SideB);
            listSides.Add(SideC);
            listSides = listSides.OrderByDescending(x => x).ToList();
            if (Math.Pow(listSides[0], 2) == Math.Pow(listSides[1], 2) + Math.Pow(listSides[2], 2))
            {
                return true;
            }

            return false;
        }
    }
}