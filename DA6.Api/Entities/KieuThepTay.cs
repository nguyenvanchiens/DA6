using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("kieutheptays")]
    public class KieuThepTay:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuThepTay { get; set; }
        public string TenKieuThepTay { get; set; }
    }
}
