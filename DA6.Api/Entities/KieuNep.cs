using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuNep
    {
        [Key]
        public string MaKieuNep { get; set; }
        public string TenKieuNep { get; set; }
    }
}
