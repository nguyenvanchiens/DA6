using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTuiTruoc:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuTuiTruoc { get; set; }
        public string TenKieuTuiTruoc { get; set; }
    }
}
