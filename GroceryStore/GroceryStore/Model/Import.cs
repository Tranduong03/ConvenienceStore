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
    [Table("IMPORT")]
    public class Import
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImportID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ImportDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,0)")]
        public decimal? TotalCost { get; set; }

        public string? Note { get; set; }

        [StringLength(128)]
        public string? ImageLink { get; set; }

        [ForeignKey("UserID")]
        public int? UserID { get; set; }
        public User? User { get; set; }
    }

    //internal class Import
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int ImportID { get; set; }

    //    [ForeignKey("Product")]
    //    public int ProductID { get; set; }

    //    [ForeignKey("Supplier")]
    //    public int SupplierID { get; set; }

    //    [Required]
    //    [DefaultValue(0)]
    //    public int Quantity {  get; set; }

    //    [Required]
    //    public int Cost { get; set; }

    //    [Required]
    //    public DateTime ImportAt { get; set; }

    //    public virtual Product ?Product { get; set; }
    //    public virtual Supplier ?Supplier { get; set; }
    //}
}
