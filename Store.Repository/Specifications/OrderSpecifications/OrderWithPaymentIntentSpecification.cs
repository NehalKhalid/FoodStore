﻿using Store.Data.Entities.OrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Specifications.OrderSpecifications
{
    public class OrderWithPaymentIntentSpecification : Specification<Order>
    {
        public OrderWithPaymentIntentSpecification(string? paymentIntent ) 
            : base(order => order.PaymentIntentId == paymentIntent)
        {
        }
    }
}
