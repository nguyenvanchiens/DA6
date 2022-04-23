using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Core.Entities
{
    /// <summary>
    /// Loại trang phục
    /// </summary>
    [Table("LoaiTrangPhuc")]
    public class LoaiTrangPhuc : BaseClass
    {
        /// <summary>
        /// Mã trang phục
        /// </summary>
        public Guid MaTP { get; set; }
        /// <summary>
        /// Tên loại trang phục
        /// </summary>
        /// 
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string? Ten { get; set; }
        /// <summary>
        /// Mô Tả
        /// </summary>
        /// 
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]
        public string? MoTa { get; set; }

    }
}
