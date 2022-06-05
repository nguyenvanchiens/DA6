using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("sanphams")]
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
    }
}
