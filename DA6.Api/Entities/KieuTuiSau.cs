using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuTuiSau
    {
        [Key]
        public string MaKieuTuiSau { get; set; }
        public string TenKieuTuiSau { get; set; }
    }
}
