using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewenWonders
{
    class Mausoleum_in_Halicarnassus
    {
        public string name { get; set; } = "Мавзолей в Галикарнасе";
        public string description { get; set; } = "гробница карийского сатрапа Мавсола, \n" +
                                                  "сооружённая в середине IV \n" +
                                                  "века до н.э. по приказу его супруги Артемисии II\n" +
                                                  "в Галикарнасе (ныне — Бодрум, Турция)";
        public string age { get; set; } = "Галикарнас, 351 г. до н.э";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" +
                              $"Описание:\n{description}\n" +
                              $"Место и возраст:\n{age}\n");
        }
    }
}
