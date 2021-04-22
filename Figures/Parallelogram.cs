using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Parallelogram : GeometricFigure
    {
        public decimal _sideA { get; set; }
        public decimal _sideB { get; set; }

        public Parallelogram(string nameFigure, decimal sideA, decimal sideB, decimal height) : base(nameFigure)
        {
            _sideA = sideA;
            _sideB = sideB;
            _height = height;
        }
        public override decimal Perimeter()
        {
            return _perimeter = 2 * (_sideA + _sideB);
        }

        public override void Print()
        {
            base.Print();
        }

        public override decimal Square()
        {
            return _square = _sideA * _height;
        }
    }
}
