using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace GroceryStore.Model
{
    internal class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [MaxLength(32, ErrorMessage = "Tài khoản không được vượt quá 32 ký tự.")]
        public string Account { get; set; }

        [Required]
        [MaxLength(61)]
        public string Password { get; set; } // Mật khẩu sẽ được lưu dưới dạng hash

        [Required]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        [MaxLength(60, ErrorMessage = "Email không được vượt quá 60 ký tự.")]
        public string Email { get; set; }

        [RegularExpression(@"^\+?[0-9]{8,12}$", ErrorMessage = "Số điện thoại phải từ 8 đến 12 chữ số, có thể bắt đầu bằng '+'.")]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(0, 2, ErrorMessage = "Giới tính không hợp lệ (0: Nam, 1: Nữ, 2: Phi nhị giới).")]
        public int Gender { get; set; }

        public string Address { get; set; }

        public string ImgLink { get; set; }
    }
}
