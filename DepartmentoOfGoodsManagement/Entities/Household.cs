using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentOfGoodsManagement.Entities
{
    class Household : Goods
    {
        private string _productGroup { get; set; }
        public Household(string name, double price, int quantity, string productGroup = "Household"):base(name, price,quantity)
        {
            _productGroup = productGroup;
        }
        
        public override string ToString()
        {
            return string.Format("Group Name:\t" + _productGroup
                + "\nDescription:\t" + _name + "\nHot Price:\t"
                + _price + "\nQuantity:\t" + _quantity + "\n");
        }
    }
}
