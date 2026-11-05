using MayNghien.Infrastructures.Models;
using ClinicFlow.Commons.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicFlow.Models.Entities
{
    public class NHANVIEN : BaseEntity
    {
        [Key]
        public Guid MaNV { get; set; }
        public string HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
