﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public int Id { get; set; }

        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        // Navigate
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}