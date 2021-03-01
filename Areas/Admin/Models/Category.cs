using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyOnline.Areas.Admin.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tên")]
        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}