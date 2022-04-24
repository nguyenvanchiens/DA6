using DA6.Api.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Core.Entities
{
    /// <summary>
    /// Chủng loại
    /// </summary>
    [Table("ChungLoai")]
    public class ChungLoai : BaseClass
    {
        /// <summary>
        /// Mã chủng loại
        /// </summary>
        /// 
        [Key]
        public Guid MaCL { get; set; }
        /// <summary>
        /// Tên chủng loại
        /// </summary>
        public string? Ten { get; set; }
        /// <summary>
        /// Mô tả chủng loại
        /// </summary>
        public string? MoTa { get; set; }
        /// <summary>
        /// Kiểu chúng loại (Ao (Sơ mi, TShirt, Polo); 
        /// Quan(Dài, Lỡ, Sooc); Jacket(Jaket 1 lớp, Jacket 1.5 lớp, 
        /// Jacket 2 lớp, jacket 2 lớp, jacket 3 lớp, jacket 5 lớp); 
        /// vest (Vest 1 lớp,Vest 1.5 lớp,Vest 2 lớp))
        /// </summary>
        public string Kieu { get; set; }
        public List<Ao> Aos { get; set; }
        public List<Quan>  Quans { get; set; }
        public List<JacKet>  JacKets { get; set; }
        public List<Vest>  Vests { get; set; }
    }
}
