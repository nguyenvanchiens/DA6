using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("phuthuocs")]
    public class PhuThuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MaOptionDaura { get; set; }
        public int MaDauRa { get; set; }
        public int MaLoaiDauRa { get; set; }
    }
}
