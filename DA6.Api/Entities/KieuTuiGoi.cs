using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTuiGoi:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuTuiGoi { get; set; }
        public string TenKieuTuiGoi { get; set; }
    }
}
