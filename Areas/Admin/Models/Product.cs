using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyOnline.Areas.Admin.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tên")]
        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm.")]
        public string Name { get; set; }
        [DisplayName("Giá")]
        [Required(ErrorMessage = "Vui lòng nhập giá sản phẩm.")]
        public double Price { get; set; }
        [DisplayName("Số lượng sản phẩm")]
        [Required(ErrorMessage = "Vui lòng nhập số lượng sản phẩm.")]
        public int Qty { get; set; }
        [DisplayName("Chi tiết sản phẩm")]
        [Required(ErrorMessage = "Vui lòng nhập chi tiết sản phẩm.")]
        public string Description { get; set; }
        [DisplayName("Kích thước viên nang")]
        [Required(ErrorMessage = "Vui lòng nhập kích thước viên nang.")]

        public string CapsuleSize { get; set; }=null;
        [DisplayName("Kích thước máy")]
        [Required(ErrorMessage = "Vui lòng nhập kích thước máy.")]
        public string MachineDimension { get; set; }=null;
        [DisplayName("Công suất máy")]
        [Required(ErrorMessage = "Vui lòng nhập công suất máy.")]
        public string ProductionOutput { get; set; }=null;
        [DisplayName("Khối lượng vận chuyển")]
        [Required(ErrorMessage = "Vui lòng nhập khối lượng vận chuyển máy.")]
        public string ShippingWeight { get; set; }=null;

        //tablet
        [DisplayName("Số khuân dập")]
        [Required(ErrorMessage = "Vui lòng nhập số khuân dập.")]
        public string NumberOfDies { get; set; }=null;
        [DisplayName("Khả năng cung cấp")]
        [Required(ErrorMessage = "Vui lòng nhập khả năng cung cấp.")]
        public string ProductionCapacity{get;set;}=null;
        [DisplayName("Kích thước viên nén")]
        [Required(ErrorMessage = "Vui lòng nhập kích thước viên nén.")]
        public string DiameterOfTheTablets{get;set;}=null;
        [DisplayName("Độ dày viên nén")]
        [Required(ErrorMessage = "Vui lòng nhập độ dày viên nén.")]
        public string ThicknessOfTablet { get;set;}=null;
        [DisplayName("Áp lực tối đa")]
        [Required(ErrorMessage = "Vui lòng nhập áp lực tối đa của máy.")]
        public string MaxPressure{get;set;}=null;
        [DisplayName("Số lượng trạm nạp")]
        [Required(ErrorMessage = "Vui lòng nhập số lượng trạm nạp.")]
        public string NumberOfFillingStations{get;set;}=null;
        [DisplayName("Cân nặng")]
        [Required(ErrorMessage = "Vui lòng nhập cân nặng.")]
        public string Weight { get;set;}=null;
        [DisplayName("Chiều cao")]
        [Required(ErrorMessage = "Vui lòng nhập chiều cao máy.")]
        public string Height { get;set;}=null;
        [DisplayName("Chiều rộng")]
        [Required(ErrorMessage = "Vui lòng nhập chiều rộng máy.")]
        public string Width { get;set;}=null;
        [DisplayName("Chiều sâu")]
        [Required(ErrorMessage = "Vui lòng nhập chiều sâu máy.")]
        public string Depth { get;set;}=null;


        //liquid
        [DisplayName("Công suất")]
        [Required(ErrorMessage = "Vui lòng nhập công suất.")]
        public string Output{get;set;}=null;
        [DisplayName("Hướng di chuyển")]
        [Required(ErrorMessage = "Vui lòng nhập hướng di chuyển.")]
        public string DirectionOfMovement{ get;set;}=null;
        [DisplayName("Kích thước đầy đủ")]
        [Required(ErrorMessage = "Vui lòng nhập kích thước.")]
        public string FullSize{get;set;}=null;
        [DisplayName("Chiều cao của băng tải")]
        [Required(ErrorMessage = "Vui lòng nhập chiều cao của băng tải.")]
        public string HeightOfConveyor { get; set; } = null;
        [DisplayName("Loại sản phẩm")]
        [Required(ErrorMessage = "Vui lòng chọn loại sản phẩm.")]
        public int CategoryID { get; set; }
        public virtual Category CategoryOfProduct { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

    }
}