using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewenWonders
{
    class Pyramid
    {
        public string name { get; set; } = "Пирамида Хеопса";
        public string description { get; set; } = "Крупнейшая из египетских пирамид, памятник\n" +
                                                  "архитектурного искусства Древнего Египта;";
        public string age { get; set; } = "Гиза, 2550 г. до н. э.";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" +
                              $"Описание:\n{description}\n" +
                              $"Место и возраст:\n{age}\n");
        }
    }
}
