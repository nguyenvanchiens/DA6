using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuThanTruoc:BaseClass
    {
        [Key]
        public string MaKieuThanTruoc { get; set; }
        public string TenKieuThanTruoc { get; set; }
    }
}
