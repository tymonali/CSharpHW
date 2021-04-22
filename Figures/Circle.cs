using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : GeometricFigure
    {
        public decimal _radius { get; set; }
        public Circle(String nameFigure, decimal radius) : base(nameFigure)
        {
            _radius = radius;
        }
        public override decimal Perimeter()
        {
            return _perimeter = 2 * pi * _radius;
        }

        public override decimal Square()
        {
            return _square = pi * _radius * _radius;
        }
        public override void Print()
        {
            Console.WriteLine($" Площадь круга {Square()} см2\n Периметр круга {Perimeter()} см\n");
        }
    }
}
