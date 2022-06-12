using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("sanphamloaidauras")]
    public class SanPhamLoaiDauRa
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MaSanPham { get; set; }
        public int MaLoaiDauRa { get; set; }
    }
}
