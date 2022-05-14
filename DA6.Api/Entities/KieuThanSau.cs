using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuThanSau:BaseClass
    {
        [Key]
        public string MaKieuThanSau { get; set; }
        public string TenKieuThanSau { get; set; }
    }
}
