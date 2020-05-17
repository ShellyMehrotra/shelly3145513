using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Model
{
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string DateTime { get; set; }
    }
}
