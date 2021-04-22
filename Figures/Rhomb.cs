using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rhomb : GeometricFigure
    {
        public decimal _dWidth { get; set; }         // Короткая диагональ
        public decimal _dHeight { get; set; }        // Длинная диагональ
        public Rhomb(string nameFigure, decimal dWidth, decimal dHeight, decimal height):base(nameFigure)
        {
            _height = height;           // Это сторона ромба!(у ромба все стороны равны!)
            _dWidth = dWidth;
            _dHeight = dHeight;
        }
        public Rhomb(string nameFigure, decimal dWidth, decimal dHeight) : base(nameFigure) // Если не извесна сторона ромба
        {
            _dWidth = dWidth;
            _dHeight = dHeight;
            double a = Convert.ToDouble(0.5M*(_dWidth * _dWidth) + 0.5M*(_dHeight * _dHeight));    // a - квадрат гипотенузы
            _height = Convert.ToDecimal( Math.Sqrt(a));   // Сторона ромба
            
        }
        public override decimal Perimeter()
        {
            return _perimeter = 4 * _height;
        }

        public override void Print()
        {
            Console.WriteLine($" Сторона ромба = {_height} см\n");
        }

        public override decimal Square()
        {
            decimal s = 0.5M * (0.5M*(_dHeight * _dWidth));     // Пощадь прямоугольного треугольника
            return _square = s * 4;
        }
    }
}
