using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuGau
    {
        [Key]
        public string MaKieuGau { get; set; }
        public string TenKieuGau { get; set; }
    }
}
