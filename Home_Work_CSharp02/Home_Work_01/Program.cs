using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_01
{
    /*
      Описать перечисление ArticleType определяющее
      типы товаров, и добавить соответствующее поле
      в структуру Article из задания №1.
    */
    enum ArticleType
    {
        Wood,
        Food,
        Fishing,
        Equipment,
        Toys
    }

    /*
      Описать перечисление PayType определяющее форму
      оплаты клиентом заказа, и добавить соответствующее
      поле в структуру Request из задания №4.
    */
    enum ClientType
    {
        Priority01,
        Priority02,
        Priority03,
        Priority04,
        Priority05
    }
    enum PayType
    {
        Card,
        WebMoney,
        Cash
    }
    /*
      Описать структуру Article, содержащую следующие
      поля: код товара; название товара; цену товара.
    */
    struct Article
    {
        public ArticleType articleType { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public decimal prise { get; set; }

        public Article(int id, string name, decimal prise, ArticleType articleType)
        {
            this.id = id;
            this.name = name;
            this.prise = prise;
            this.articleType = articleType;
        }
    }

    /*
      Описать структуру Client содержащую поля: код
      клиента; ФИО; адрес; телефон; количество заказов
      осуществленных клиентом; общая сумма заказов
      клиента.
    */
    struct Client
    {
        public ClientType clientType { get; set; }
        public int id { get; set; }
        public string FIO { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int ordersCount { get; set; }
        public int ordersCapasity { get; set; }

        public Client(int id, string FIO, string address, string phone,
                      int ordersCount, int ordersCapasity, ClientType clientType)
        {
            this.id = id;
            this.FIO = FIO;
            this.address = address;
            this.phone = phone;
            this.ordersCount = ordersCount;
            this.ordersCapasity = ordersCapasity;
            this.clientType = clientType;
        }
    }

    /*
      Описать структуру RequestItem содержащую поля:
      товар; количество единиц товара.
    */
    struct RequestItem
    {
        public string name { get; set; }
        public int count { get; set; }
        public RequestItem(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
    }

    /*
      Описать структуру Request содержащую поля: код
      заказа; клиент; дата заказа; перечень заказанных товаров;
      сумма заказа (реализовать вычисляемым свойством).
    */
    struct Request
    {
        
        public Article art;
        public Client cl;
        public string orderDate { get; set; }
        public Article[] mas;
        public decimal sumOrder
        {
            get
            {
                decimal sum = 0;
                foreach (var prise in mas)
                {
                    sum += prise.prise;
                }
                return sum;
            }
        }
        public PayType payType { get; set; }
        
        public Request(Article art, Client cl, string orderDate, Article[] mas, PayType payType)
        {
            this.art = art;
            this.cl = cl;
            this.orderDate = orderDate;
            this.mas = mas;
            this.payType = payType;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
