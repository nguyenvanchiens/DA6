using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("optiondauras")]
    public class OptionDauRa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MaPhuThuoc { get; set; }
        public int MaDauRa { get; set; }
        public int MaQuanLyDauRa { get; set; }
    }
}
