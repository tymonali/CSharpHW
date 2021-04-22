/****************************************************************
 *    1.	Даны целые положительные числа A, B, C. Значение    *
 *   этих чисел программа должна запрашивать у пользо-          *
 *   вателя. На прямоугольнике размера A*B размещено            *
 *   максимально возможное количество квадратов со              *
 *   стороной C. Квадраты не накладываются друг на              *
 *   друга. Найти количество квадратов, размещенных на          *
 *   прямоугольнике, а также площадь незанятой части            *
 *   прямоугольника.                                            *
 *   Необходимо предусмотреть служебные сообщения               *
 *   в случае, если в прямоугольнике нельзя разместить ни       *
 *   одного квадрата со стороной С (например, если зна-         *
 *   чение С превышает размер сторон прямоугольника).           *
 ****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Введите A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите C:");
            C = int.Parse(Console.ReadLine());
            while (C > A || C > B)
            {
                Console.WriteLine("Ваш квадрат ни разу не влезет в прямоугольник!");
                Console.WriteLine("Введите C < A и C < B");
                C = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Прямоугольник со сторонами:");
            Console.WriteLine("A = " + A + ", B = " + B);
            Console.WriteLine("Квадрат со стороной:");
            Console.WriteLine("C = " + C);
            int res = (A / C) * (B / C);
            int ost = (A % C) * (B % C);
            Console.WriteLine("Квадрат поместится в прямоугольнике: " + res + " раз");
            Console.WriteLine("Площадь оставшегося места: " + ost);
        }
    }
}
