using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuCuaQuan:BaseClass
    {
        [Key]
        public string MaKieuCuaQuan { get; set; }
        public string TenKieuCuaQuan { get; set; }
    }
}
