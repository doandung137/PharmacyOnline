﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyOnline.Areas.Admin.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double GrandTotal { get; set; }
        public string IncrementID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Users Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}