using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
        public string Username { get; set; }

        [Display(Name = "Mật khẩu")]
        public string? PasswordHash { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vai trò là bắt buộc")]
        public string Role { get; set; } // Admin, Staff, Customer

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
