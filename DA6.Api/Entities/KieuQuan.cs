using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuQuan
    {
        [Key]
        public string MaKieuQuan { get; set; }
        public string TenKieuQuan { get; set; }
    }
}
