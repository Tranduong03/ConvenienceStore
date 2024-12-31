using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    [Table("IMPORTDETAIL")]
    public class ImportDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailID { get; set; }  

        [Required]
        public int Quantity { get; set; }  

        [Required]
        [Column(TypeName = "decimal(10,0)")]
        public decimal UnitPrice { get; set; }  

        [NotMapped]  
        public decimal Price => Quantity * UnitPrice;  

        // Khóa ngoại
        [ForeignKey("Import")]
        public int ImportID { get; set; }
        public virtual Import ? Import { get; set; }  

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product ? Product { get; set; }  

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public virtual Supplier ? Supplier { get; set; }
    }
}
