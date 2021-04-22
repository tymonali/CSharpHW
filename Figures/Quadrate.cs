using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Quadrate : GeometricFigure
    {
        public Quadrate(string nameFigure, decimal height):base(nameFigure)
        {
            _height = height;
        }
        public override decimal Perimeter()
        {
            return _perimeter = _height * 4;
        }

        public override void Print()
        {
            base.Print();
        }

        public override decimal Square()
        {
            return _square = _height * _height;
        }
    }
}
