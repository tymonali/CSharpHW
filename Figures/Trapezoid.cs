using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Trapezoid : GeometricFigure
    {
        public decimal _a { get; set; }     // Первое основание
        public decimal _b { get; set; }     // Второе основание
        public decimal _c { get; set; }
        public decimal _d { get; set; }
        public Trapezoid(string nameFigure, decimal a, decimal b, decimal c, decimal d, decimal height) : base(nameFigure)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _height = height;
        }

        public override decimal Perimeter()
        {
            return _perimeter = _a + _b + _c + _d;
        }

        public override decimal Square()
        {
            decimal sumAB = _a + _b;
            return _square = 0.5M * sumAB * _height;
        }

        public override void Print()
        {
            Console.WriteLine($" Площадь Трапеции {Square()} см2 \n Периметр Трапеции {Perimeter()} см\n");
        }
    }
}
