using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuTuiTruoc
    {
        [Key]
        public string MaKieuTuiTruoc { get; set; }
        public string TenKieuTuiTruoc { get; set; }
    }
}
