using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentOfGoodsManagement.Entities
{
    abstract class Goods
    {
        public double _price { get; set; }
        public string _name { get; set; }
        public int _quantity { get; set; }

        public Goods(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        public abstract override string ToString();
    }
}
