using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Entitites;

namespace test.Configurations
{
    public class OrderDetailsConfiguration : EntityConfiguration<OrderDetails>
    {

        public OrderDetailsConfiguration()
        {
            Property(o => o.Quatity).IsRequired();
        }
    }
}