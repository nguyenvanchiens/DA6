using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public Guid NguoiDungId { get; set; }
        public string TenNguoiDung { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string Quyen { get; set; }
    }
}
