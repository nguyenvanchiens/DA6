using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuThanSau
    {
        [Key]
        public string MaKieuThanSau { get; set; }
        public string TenKieuThanSau { get; set; }
    }
}
