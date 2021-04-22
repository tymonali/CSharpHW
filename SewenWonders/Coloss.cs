using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Разработайте приложение «7 чудес света», где каждое
    чудо будет представлено отдельным классом. Создай-
    те дополнительный класс, содержащий точку входа.
    Распределите приложение по файлам проекта и с по-
    мощью пространства имён обеспечьте возможность
    взаимодействия классов. 
*/

namespace SewenWonders
{
    class Coloss
    {
        public string name { get; set; } = "Колосс Родосский";
        public string description { get; set; } = "Гигантская статуя древнегреческого бога Солнца — Гелиоса";
        public string age { get; set; } = "Родос, между 292 и 280 гг. до н. э";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" + 
                              $"Описание:\n{description}\n" + 
                              $"Место и возраст:\n{age}\n");
        }
    }
    
}
