using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    [Table("kieucuaquans")]
    public class KieuCuaQuan:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKieuCuaQuan { get; set; }
        public string TenKieuCuaQuan { get; set; }
    }
}
