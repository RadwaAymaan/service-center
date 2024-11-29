using ServiceCenter.Domain.Entities;
using ServiceCenter.Domain.Enums;
using ServiceCenter.Infrastructure.BaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Test.TestSetup.Data;

public static class OrderTest
{
    public static void AddOrder(this ServiceCenterBaseDbContext context)
    {
        context.Orders.AddRange(
        new Order
        {
            Id = 1,
              OrderStatus = Status.Pending,
        },
        new Order
        {
            Id = 2,
           
        }

      );
    }
}
