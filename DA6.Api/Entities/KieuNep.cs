using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuNep:BaseClass
    {
        [Key]
        public string MaKieuNep { get; set; }
        public string TenKieuNep { get; set; }
    }
}
