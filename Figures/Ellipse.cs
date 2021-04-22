using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Ellipse : GeometricFigure
    {
        public decimal _radiusWidth { get; set; }   // длина малой полуоси
        public decimal _radiusHeight { get; set; }  // длина большой полуоси
        public Ellipse(string nameFigure, decimal radiusWidth, decimal radiusHeight) : base(nameFigure)
        {
            _radiusWidth = radiusWidth;
            _radiusHeight = radiusHeight;
        }
        public override decimal Perimeter()
        {
            return _perimeter = 4 * (((pi * _radiusWidth * _radiusHeight) + (_radiusHeight - _radiusWidth))/(_radiusWidth + _radiusHeight));
        }

        public override void Print()
        {
            Console.WriteLine($" Площадь  эллипса {Square()} см2\n Периметр эллипса {Perimeter()} см\n");
        }

        public override decimal Square()
        {
            return _square = pi * _radiusWidth * _radiusHeight;
        }
    }
}
