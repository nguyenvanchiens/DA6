using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("files")]
    public class Files:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaFile { get; set; }
        public string TenFile { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }
    }
}
