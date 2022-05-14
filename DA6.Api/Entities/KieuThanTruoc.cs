using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuThanTruoc
    {
        [Key]
        public string MaKieuThanTruoc { get; set; }
        public string TenKieuThanTruoc { get; set; }
    }
}
