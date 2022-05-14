using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuCuaQuan
    {
        [Key]
        public string MaKieuCuaQuan { get; set; }
        public string TenKieuCuaQuan { get; set; }
    }
}
