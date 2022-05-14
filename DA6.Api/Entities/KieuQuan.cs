using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuQuan : BaseClass
    {
        [Key]
        public string MaKieuQuan { get; set; }
        public string TenKieuQuan { get; set; }
    }
}
