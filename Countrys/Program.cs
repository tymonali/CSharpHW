using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Разработать приложение, в котором бы сравнивалось
    население трёх столиц из разных стран. Причём стра-
    на бы обозначалась пространством имён, а город —
    классом в данном пространстве.
*/
using Ukraine;
using Russia;
using Belarus;

namespace Countrys
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiyv kiyv = new Kiyv
            {
                Population = 2967000
            };
            Minsk minsk = new Minsk
            {
                Population = 2018281
            };
            Moskow moskow = new Moskow
            {
                Population = 12655050
            };
            string str_1, str_2, str_3;
            if(kiyv.Population > minsk.Population && 
               kiyv.Population > moskow.Population)
            {
                str_1 = kiyv.ToString();
                if (minsk.Population > moskow.Population) 
                {
                    str_2 = minsk.ToString();
                    str_3 = moskow.ToString();
                }
                else 
                {
                    str_3 = minsk.ToString();
                    str_2 = moskow.ToString();
                }
            }
            else if(minsk.Population > kiyv.Population &&
                    minsk.Population > moskow.Population)
            {
                str_1 = minsk.ToString();
                if (kiyv.Population > moskow.Population)
                {
                    str_2 = kiyv.ToString();
                    str_3 = moskow.ToString();
                }
                else
                {
                    str_3 = kiyv.ToString();
                    str_2 = moskow.ToString();
                }
            }
            else
            {
                str_1 = moskow.ToString();
                if(kiyv.Population > minsk.Population)
                {
                    str_2 = kiyv.ToString();
                    str_3 = minsk.ToString();
                }
                else
                {
                    str_3 = kiyv.ToString();
                    str_2 = minsk.ToString();
                }
            }
            Console.WriteLine($"На первом месте по населению: {str_1}");
            Console.WriteLine($"На втором месте по населению: {str_2}");
            Console.WriteLine($"На третьем месте по населению: {str_3}");
        }
    }
}
