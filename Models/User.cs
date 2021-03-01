using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyOnline.Areas.Admin.Models
{
    public class Users
    {
        [Key]
        public int? ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [DisplayName("SĐT")]
        [Required(ErrorMessage = "Vui lòng nhập SĐT.")]
        public string Phone { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Vui lòng nhập họ và tên.")]
        public string FullName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email.")]
        public string Email { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        public string Address { get; set; }
        [DisplayName("Cấp quyền")]
        [Required(ErrorMessage = "Vui lòng chọn quyền")]
        public Role Role { get; set; }
        public DateTime? CreatedAt { get; set; }
        
        public string Status { get; set; }

    }
}
    