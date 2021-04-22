using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : GeometricFigure
    {
        public decimal _a { get; set; }     
        public decimal _b { get; set; }
        public decimal _c { get; set; }
        public Triangle(string nameFigure, decimal a, decimal b, decimal c, decimal height):base(nameFigure)
        {
            _a = a;
            _b = b;
            _c = c;
            _height = height;
        }
        public override decimal Perimeter()
        {
            return _perimeter = _a + _b + _c;
        }

        public override void Print()
        {
            base.Print();
        }

        public override decimal Square()
        {
            decimal _p = 0.5M * (_a + _b + _c);     // Полупериметр
            double _s = Convert.ToDouble(_p * (_p - _a) * (_p - _b) * (_p - _c));
            _square = Convert.ToDecimal(Math.Sqrt(_s));
            //_square = 0.5M * _a * _height;
            return _square;
        }
    }
}
