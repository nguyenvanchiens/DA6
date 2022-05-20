using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    [Table("kieuthantruocs")]
    public class KieuThanTruoc:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuThanTruoc { get; set; }
        public string TenKieuThanTruoc { get; set; }
    }
}
