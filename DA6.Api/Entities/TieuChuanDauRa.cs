using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("tieuchuandauras")]
    public class TieuChuanDauRa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma { get; set; }
        public string Ten { get; set; }
    }
}
