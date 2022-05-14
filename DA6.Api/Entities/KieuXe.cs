using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuXe:BaseClass
    {
        [Key]
        public string MaKieuXe { get; set; }
        public string TenKieuXe { get; set; }
    }
}
