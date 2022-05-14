using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuCap
    {
        [Key]
        public string MaKieuCap { get; set; }
        public string TenKieuCap { get; set; }
    }
}
