using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Entitites;

namespace test.Configurations
{
    public class OrderConfiguration : EntityConfiguration<Order>
    {
        public OrderConfiguration()
        {
            Property(o => o.OrderDate).IsRequired();
        }
    }
}