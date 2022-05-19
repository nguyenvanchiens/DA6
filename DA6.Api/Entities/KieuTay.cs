using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTay:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuTay { get; set; }
        public string TenKieu { get; set; }
    }
}
