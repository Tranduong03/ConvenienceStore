using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    internal class ImportProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImportID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Quantity {  get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public DateTime ImportAt { get; set; }

        public virtual Product ?Product { get; set; }
        public virtual Supplier ?Supplier { get; set; }
    }
}
