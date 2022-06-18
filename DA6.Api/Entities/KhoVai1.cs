using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("khovai1s")]
    public class KhoVai1 : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKhoVai1 { get; set; }
        public int TenKhoVai1 { get; set; }
    }
}
