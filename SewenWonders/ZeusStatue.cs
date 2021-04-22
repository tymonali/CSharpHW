using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewenWonders
{
    class ZeusStatue
    {
        public string name { get; set; } = "Статуя Зевса в Олимпии";
        public string description { get; set; } = "Статуя Зевса в Олимпии — единственное из Семи чудес света,\n" +
                                                  "которое располагалось в материковой части Европы (в городе Олимпия)";
        public string age { get; set; } = "Олимпия, 435 г. до н. э";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" +
                              $"Описание:\n{description}\n" +
                              $"Место и возраст:\n{age}\n");
        }
    }
}
