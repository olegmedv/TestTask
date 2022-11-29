using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreas
{
    public interface IFigure
    {
        void Validate();
        double CalculateArea();
    }
}
