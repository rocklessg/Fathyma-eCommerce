using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FathymaPieShop.Models
{
    public interface IOrderRepository
    {
        void CreatOrder(Order order);
    }
}
