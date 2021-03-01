using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyOnline.Areas.Admin.Models
{
    public class Permission
    {
        [Key]
        public int ID { get; set; }

        public int? Role_ID { get; set; }
        public int? User_ID { get; set; }
    }
}