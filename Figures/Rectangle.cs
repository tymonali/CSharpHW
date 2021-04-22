using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : GeometricFigure
    {
        public decimal _sideA { get; set; }
        public decimal _sideB { get; set; }
        public Rectangle(string nameFigure, decimal sideA, decimal sideB) : base(nameFigure)
        {
            _sideA = sideA;
            _sideB = sideB;
        }
        public override decimal Perimeter()
        {
            return _perimeter = _sideA * 2 + _sideB * 2;
        }

        public override void Print()
        {
            base.Print();
        }

        public override decimal Square()
        {
            return _square = _sideA * _sideB;
        }
    }
}
