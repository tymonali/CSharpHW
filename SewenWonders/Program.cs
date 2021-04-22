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

namespace SewenWonders      // SevenWonders
{
    class Program
    {
        static void Main(string[] args)
        {
            Coloss coloss = new Coloss();
            coloss.Show();
            Hanging_Gardens_of_Babylon hgb = new Hanging_Gardens_of_Babylon();
            hgb.Show();
            Pyramid pyramid = new Pyramid();
            pyramid.Show();
            ZeusStatue zs = new ZeusStatue();
            zs.Show();
            Temple_of_Artemis_Efesse tae = new Temple_of_Artemis_Efesse();
            tae.Show();
            Mausoleum_in_Halicarnassus mih = new Mausoleum_in_Halicarnassus();
            mih.Show();
            Alexandrian_Lighthouse al = new Alexandrian_Lighthouse();
            al.Show();
        }
    }
}
