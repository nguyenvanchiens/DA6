using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuCo:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuCo { get; set; }
        public string TenKieuCo { get; set; }
    }
}
