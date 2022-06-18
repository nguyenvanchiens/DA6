using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("thanhphanvais2")]
    public class ThanhPhanVai2 : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThanhPhanVai2 { get; set; }
        public string TenThanhPhanVai2 { get; set; }
    }
}
