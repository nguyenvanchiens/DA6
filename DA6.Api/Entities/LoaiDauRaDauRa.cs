using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("loaidauradauras")]
    public class LoaiDauRaDauRa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MaDauRa { get; set; }
        public int MaLoaiDauRa { get; set; }
    }
}
