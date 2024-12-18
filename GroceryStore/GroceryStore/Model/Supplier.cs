using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    internal class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity Column
        public int SupplierID { get; set; } // Thay MaNCC bằng SupplierID

        [Required] // NOT NULL
        [MaxLength(40)] // NVARCHAR(40)
        public string Name { get; set; } // Thay TenNCC bằng Name

        [MaxLength(100)] // VARCHAR(100)
        public string Email { get; set; }

        [MaxLength(60)] // NVARCHAR(60)
        public string Address { get; set; } // Thay DiaChi bằng Address

        [MaxLength(24)] // NVARCHAR(24)
        public string FAX { get; set; }
    }
}
