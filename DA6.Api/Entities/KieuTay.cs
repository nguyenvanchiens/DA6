using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuTay
    {
        [Key]
        public string MaKieuTay { get; set; }
        public string TenKieu { get; set; }
    }
}
