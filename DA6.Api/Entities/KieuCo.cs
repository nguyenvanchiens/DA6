using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuCo:BaseClass
    {
        [Key]
        public string MaKieuCo { get; set; }
        public string TenKieuCo { get; set; }
    }
}
