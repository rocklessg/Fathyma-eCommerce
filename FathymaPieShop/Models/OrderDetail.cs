using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FathymaPieShop.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PieId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Pie Pie { get; set; }
        public Order Order { get; set; }
    }
}
