using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("optionaos")]
    public class OptionAo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MaAo { get; set; }
        public int MaKieuTay { get; set; }
        public int MaKieuCuaTay { get; set; }
        public int MaKieuGau { get; set; }
        public int MaKieuCo { get; set; }
        public int MaKieuTui { get; set; }
        public int MaKieuNep { get; set; }
        public int MaKieuThanTruoc { get; set; }
        public int MaKieuXe { get; set; }
        public int MaKieuThanSau { get; set; }
        public int MaThanhPhanVai1 { get; set; }
        public int MaThanhPhanVai2 { get; set; }
        public int MaThanhPhanVai3 { get; set; }
    }
}
