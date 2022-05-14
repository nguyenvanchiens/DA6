using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuXe
    {
        [Key]
        public string MaKieuXe { get; set; }
        public string TenKieuXe { get; set; }
    }
}
