using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    [Table("BILL")]
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }  

        [Required]
        public DateTime BillDate { get; set; }  

        [Column(TypeName = "decimal(18,0)")]
        public decimal? TotalCost { get; set; } 

        // Khóa ngoại
        [ForeignKey("User")]
        public int? UserID { get; set; }
        public virtual User? User { get; set; } 

        [ForeignKey("Customer")]
        public int? CustomerID { get; set; }
        public virtual Customer? Customer { get; set; } 
    }

    //internal class Bill
    //{
    //    [Key]
    //    public int BillId { get; set; }
    //    // Cấu hình BillCode = string("FLBill" + BillID)
    //    public string ? BillCode { get; set; }

    //    [ForeignKey("Customer")]
    //    public int CustomerID { get; set; }

    //    [ForeignKey("User")] // Là nhân viên
    //    public int UserID { get; set; }

    //    [Required]
    //    public DateTime? BillDate { get; set; }

    //    [Required]
    //    public long TotalCost { get; set; }

    //    public virtual Customer ? Customer { get; set; }
    //    public virtual User ? User { get; set; }
    //}
}
