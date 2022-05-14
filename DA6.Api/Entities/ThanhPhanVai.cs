using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class ThanhPhanVai
    {
        [Key]
        public string MaThanhPhanVai { get; set; }
        public string TenThanhPhanVai { get; set; }
    }
}
