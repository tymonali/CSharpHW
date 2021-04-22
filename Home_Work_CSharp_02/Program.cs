/*************************************************************
 *    Начальный вклад в банке равен 10000 грн . Через        *
 *   каждый месяц размер вклада увеличивается на P           *
 *   процентов от имеющейся суммы (P — вещественное          *
 *   число, 0 < P < 25) . Значение Р программа должна полу-  *
 *   чать у пользователя . По данному P определить через     *
 *   сколько месяцев размер вклада превысит 11000 грн .,     *
 *   и вывести найденное количество месяцев K (целое         *
 *   число) и итоговый размер вклада S (вещественное         *
 *   число) .                                                *
 *************************************************************/                                                          
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_CSharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш вклад в банке равен 10000 грн");
            Console.WriteLine("Введите процент ежемесячного начисления(0 < P < 25P):");
            decimal vklad = 10000, p, p_grn;
            p = decimal.Parse(Console.ReadLine());
            int i = 1;                          // Месяц
            while(vklad <= 11000)
            {
                p_grn = (p * vklad) / 100;
                vklad += p_grn;
                i++;
            }
            Console.WriteLine("Ваш депозит превысит 11000 через " + i + " месяца(ев)");
            Console.WriteLine("Итоговый размер вклада: " + vklad);
        }
    }
}
