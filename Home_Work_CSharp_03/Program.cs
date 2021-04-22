using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B(B > A):");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            for (int i = a; i <= b; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
