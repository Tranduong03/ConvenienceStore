    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GroceryStore.Model
{
    [Table("PRODUCT")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(128)]
        public string ProductName { get; set; } = "Tên sản phẩm";

        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal SellPrice { get; set; }

        [StringLength(128)]
        public string? Description { get; set; } = "Sản phẩm này không có mô tả";

        [Column(TypeName = "int")]
        public int Stock { get; set; } = 0;

        [StringLength(128)]
        public string? ImageLink { get; set; }

        [ForeignKey("CategoryID")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("SupplierID")]
        public int? SupplierID { get; set; }
        public Supplier? Supplier { get; set; }
    }

    //internal class Product
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int ProductID { get; set; }

    //    [Required]
    //    [MaxLength(100)] // Giới hạn độ dài tên
    //    public string? Name { get; set; }

    //    [ForeignKey("Category")]
    //    public int CategoryID { get; set; }

    //    [ForeignKey("Supplier")]
    //    public int SupplierID { get; set; }

    //    [Required]
    //    public int SellPrice { get; set; }

    //    [MaxLength(500)] // Giới hạn độ dài mô tả
    //    [DefaultValue("None")]
    //    public string ? Description { get; set; }

    //    [Required]
    //    public int Quantity { get; set; }

    //    [MaxLength(255)] // Giới hạn độ dài link ảnh
    //    [DefaultValue("none.png")]
    //    public string ?ImageLink { get; set; }

    //    // Navigation property (tùy chọn, nếu có bảng Category)
    //    public virtual Category? Category { get; set; }
    //    public virtual Supplier? Supplier { get; set; }
    //}
}
