using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class GeometricFigure
    {
        // Периметр фигуры:
        public decimal _perimeter { get; set; }
        // Площадь фигуры:
        public decimal _square { get; set; }
        // Высота фигуры:
        public decimal _height { get; set; }
        // Число ПИ
        public const decimal pi = 3.14M;
        // Строка для названия фигуры
        public string _nameFigure { get; set; }


        // Конструктор с параметром, принимающим строку с названием фигуры
        public GeometricFigure(string nameFigure)
        {
            _nameFigure = nameFigure;
        }


        // Абстрактный метод для получения периметра
        public abstract decimal Perimeter();
        // абстрактный метод для получения площади
        public abstract decimal Square();

        public void PrintFigure()
        {
            Console.WriteLine($" Площадь {_nameFigure}а {Square()} см2 \n Периметр {_nameFigure}а {Perimeter()} см \n");
        }

        public virtual void Print()
        {
            Console.WriteLine($" Площадь фигуры {Square()} см2 \n Периметр фигуры {Perimeter()} см \n");
        }
    }
}
