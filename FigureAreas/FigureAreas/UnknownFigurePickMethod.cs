namespace FigureAreas
{
    public class UnknownFigurePickMethod : IFigure
    {
        private double CountNodesBoundaries { get; }
        private double CountNodesInside { get; }

        public UnknownFigurePickMethod(double countNodesBoundaries, double countNodesInside)
        {
            CountNodesBoundaries = countNodesBoundaries;
            CountNodesInside = countNodesInside;
            Validate();
        }

        public void Validate()
        {
            if (CountNodesBoundaries <= 0 || CountNodesInside <= 0)
            {
                throw new ArgumentException("Nodes cannot be lesser or equal zero.");
            }
        }

        public double CalculateArea()
        {
            //https://en.wikipedia.org/wiki/Pick%27s_theorem
            var unknownFigureArea = CountNodesBoundaries/2 + CountNodesInside - 1;
            return unknownFigureArea;
        }
    }
}