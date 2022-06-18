using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("thanhphanvais3")]
    public class ThanhPhanVai3 : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThanhPhanVai3 { get; set; }
        public string TenThanhPhanVai3 { get; set; }
    }
}
