using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuGau:BaseClass
    {
        [Key]
        public string MaKieuGau { get; set; }
        public string TenKieuGau { get; set; }
    }
}
