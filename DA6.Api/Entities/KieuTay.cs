using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTay:BaseClass
    {
        [Key]
        public string MaKieuTay { get; set; }
        public string TenKieu { get; set; }
    }
}
