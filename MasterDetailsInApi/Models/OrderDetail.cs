﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetailsInApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }

        public int OrderId { get; set; }
        public OrderMaster OrderMaster { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}