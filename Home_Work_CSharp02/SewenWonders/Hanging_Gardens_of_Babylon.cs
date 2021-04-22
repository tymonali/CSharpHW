using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewenWonders
{
    class Hanging_Gardens_of_Babylon
    {
        public string name { get; set; } = "Висячие сады Семирамиды";
        public string description { get; set; } = "Инженерное сооружение в Вавилоне с каскадом многоуровневых садов,\n" +
                                                  "где росли многочисленные породы деревьев, кустарников и виноградных\n" +
                                                  "лоз, производившее впечатление большой зелёной горы.";
        public string age { get; set; } = "Вавилон, 600 г. до н. э";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" +
                              $"Описание:\n{description}\n" +
                              $"Место и возраст:\n{age}\n");
        }
    }
}
