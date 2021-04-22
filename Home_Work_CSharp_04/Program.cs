/***********************************************************
 *    Дано целое число N большее 0, найти число, получен-   *
 *   ное при прочтении числа N справа налево. Например,     *
 *   если было введено число 345, то программа должна       *
 *   вывести число 543.                                     *
 ***********************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_CSharp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 524;
            Console.WriteLine("N = " + n);
            int b = (n / 100) + (((n % 100) / 10) * 10) + ((n % 100) % 10) * 100;
            Console.WriteLine("B = " + b);
        }
    }
}
