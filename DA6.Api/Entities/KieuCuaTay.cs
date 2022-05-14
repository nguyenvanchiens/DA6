using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class KieuCuaTay
    {
        [Key]
        public string MaKieuCuaTay { get; set; }
        public string TenKieuCuaTay { get; set; }
    }
}
