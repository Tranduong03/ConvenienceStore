using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    using System.ComponentModel.DataAnnotations;

    [Table("CATEGORY")] 
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int CategoryID { get; set; } 

        [Required]
        [StringLength(128)] 
        public string ? CName { get; set; } = "Phân loại hàng hóa mới";

        [StringLength(255)]
        public string? Description { get; set; } = "Không có mô tả cho loại sản phẩm này";
    }

    //internal class Category
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int CategoryID { get; set; }
    //    [Required]
    //    [MaxLength(30)]
    //    public string ? Name { get; set; }
    //    public string Description { get; set; } = "Không có mô tả cho loại sản phẩm này";
    //}
}
