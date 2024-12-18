using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    internal class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(60, ErrorMessage = "Email không được vượt quá 60 ký tự.")]
        public string Email { get; set; }

        public string Address { get; set; }

        [Required]                
        [RegularExpression(@"^\+?[0-9]{8,12}$", ErrorMessage = "Số điện thoại phải từ 8 đến 12 chữ số, có thể bắt đầu bằng '+'.")]
        [MaxLength(15)]
        public string PhoneNumber {  get; set; }
        [Required]
        [Range(0, 2, ErrorMessage = "Giới tính không hợp lệ (0: Nam, 1: Nữ, 2: Phi nhị giới).")]
        public int Gender {  get; set; }

        public DateTime dateJoin { get; set; }
    }
}
