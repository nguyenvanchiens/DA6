using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuTui
    {
        [Key]
        public string MaKieuTui { get; set; }
        public string TenKieuTui { get; set; }
    }
}
