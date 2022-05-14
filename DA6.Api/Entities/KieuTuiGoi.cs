using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuTuiGoi
    {
        [Key]
        public string MaKieuTuiGoi { get; set; }
        public string TenKieuTuiGoi { get; set; }
    }
}
