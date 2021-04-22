using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewenWonders
{
    class Alexandrian_Lighthouse
    {
        public string name { get; set; } = "Александрийский маяк";
        public string description { get; set; } = "Маяк на острове Фарос около египетского\n" +
                                                  "города Александрии, одно из семи чудес света";
        public string age { get; set; } = "Александрия, III век до н.э";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" +
                              $"Описание:\n{description}\n" +
                              $"Место и возраст:\n{age}\n");
        }
    }
}
