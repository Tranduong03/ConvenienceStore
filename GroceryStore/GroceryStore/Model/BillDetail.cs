using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    internal class BillDetail
    {
        [ForeignKey("Bill")]
        public int BillId { get; set; } 

        [ForeignKey("Product")]
        public int ProductID { get; set; } 

        [Required]
        public int Quantity { get; set; }

        [Required]// SellPrice của chi tiết hóa đơn, tham chiếu prodID, value = prodID.SellPrice(tại thời điểm mua) * Quantity
                  // không phải giá trị sellprice của product
        public int SellPrice { get; set; }

        public virtual Bill ? Bill { get; set; } 
        public virtual Product ? Product { get; set; } 
    }

}
