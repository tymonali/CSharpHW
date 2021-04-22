using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentOfGoodsManagement.Entities
{
    enum Status
    {
        Dispatched, Sold, Transmitted, Written
    }
    class Flow
    {
        public Goods[] _lot { get; set; }
        public Status _condition { get; set; }

        public Flow(Goods[] lot, Status condition)
        {
            _lot = lot;
            _condition = condition;
        }
        public override string ToString()
        {
            return string.Format("Set Condition:\t{0}\n",
                _condition);
        }

        public void Print()
        {
            foreach (var item in _lot)
            {
                Console.WriteLine($"Condition:\t{_condition}");
                Console.WriteLine(item);
            }
        }
    }
}
