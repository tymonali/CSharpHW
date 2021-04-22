using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class CompositeFigure
    {
        public decimal _allSquare = 0;
        public GeometricFigure[] geoFigure { get; set; }

        public CompositeFigure(params GeometricFigure[] geoFigure)
        {
            this.geoFigure = geoFigure;
        }

        public decimal Square()
        {
            for(int i = 0; i < geoFigure.Length; i++)
            {
                _allSquare += geoFigure[i].Square();
            }
            return _allSquare;
        }

        public void Print()
        {
            Console.WriteLine($" Площадь составной фигуры {Square()} см2\n");
        }
    }
}
