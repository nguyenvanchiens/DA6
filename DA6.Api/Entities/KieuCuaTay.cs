using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuCuaTay:BaseClass
    {
        [Key]
        public string MaKieuCuaTay { get; set; }
        public string TenKieuCuaTay { get; set; }
    }
}
