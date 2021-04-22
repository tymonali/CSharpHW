using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewenWonders
{
    class Temple_of_Artemis_Efesse
    {
        public string name { get; set; } = "Храм Артемиды Эфесской";
        public string description { get; set; } = "Известный также как Храм Диа́ны — \n" +
                                                  "одно из Семи чудес античного мира,\n" +
                                                  "греческий храм, посвящённый местному\n" +
                                                  "культу богини Артемиды";
        public string age { get; set; } = "Эфес, 550 г. до н. э";
        public void Show()
        {
            Console.WriteLine($"Имя:\n{name}\n" +
                              $"Описание:\n{description}\n" +
                              $"Место и возраст:\n{age}\n");
        }
    }
}
