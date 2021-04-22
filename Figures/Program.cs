using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Круг", 8);
            circle.Perimeter();
            circle.Square();
            circle.Print();

            Ellipse ellipse = new Ellipse("Эллипс", 5, 8);
            ellipse.Perimeter();
            ellipse.Square();
            ellipse.Print();

            Parallelogram p = new Parallelogram("Параллелограмм", 12, 6, 5.9M);
            p.Perimeter();
            p.Square();
            p.PrintFigure();

            Rectangle r = new Rectangle("Прямоугольник", 6, 12);
            r.Perimeter();
            r.Square();
            r.PrintFigure();

            Rhomb rhomb = new Rhomb("Ромб", 4, 9);
            rhomb.Perimeter();
            rhomb.Square();
            rhomb.PrintFigure();
            rhomb.Print();

            Triangle tr = new Triangle("Треугольник", 3, 5, 4, 6);
            tr.Perimeter();
            tr.Square();
            tr.PrintFigure();

            Trapezoid trap = new Trapezoid("Трапеция", 5, 6, 4, 7, 6.5M);
            trap.Perimeter();
            trap.Square();
            trap.Print();

            Quadrate quad = new Quadrate("Квадрат", 8);
            quad.Perimeter();
            quad.Square();
            quad.PrintFigure();

            GeometricFigure[] geoFig = { quad, tr, r };

            CompositeFigure cf = new CompositeFigure(geoFig);
            cf.Print();
        }
    }
}
