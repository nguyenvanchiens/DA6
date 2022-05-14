using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuCo
    {
        [Key]
        public string MaKieuCo { get; set; }
        public string TenKieuCo { get; set; }
    }
}
