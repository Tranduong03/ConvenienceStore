using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    [Table("BILLDETAIL")]
    public class BillDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillDetailID { get; set; }  

        [Required]
        public int Quantity { get; set; }  
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }  

        [NotMapped]  
        public decimal TotalPrice => Quantity * UnitPrice; 

        // Khóa ngoại
        [ForeignKey("Bill")]
        public int BillID { get; set; }
        public virtual Bill ? Bill { get; set; }  

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product ? Product { get; set; }  
    }

    //internal class BillDetail
    //{
    //    [ForeignKey("Bill")]
    //    public int BillId { get; set; } 

    //    [ForeignKey("Product")]
    //    public int ProductID { get; set; } 

    //    [Required]
    //    public int Quantity { get; set; }

    //    [Required]// SellPrice của chi tiết hóa đơn, tham chiếu prodID, value = prodID.SellPrice(tại thời điểm mua) * Quantity
    //              // không phải giá trị sellprice của product
    //    public int SellPrice { get; set; }

    //    public virtual Bill ? Bill { get; set; } 
    //    public virtual Product ? Product { get; set; } 
    //}
}
