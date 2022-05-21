using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("quytrinhsanphams")]
    public class QuyTrinhSanPham: BaseClass
    {
        /// <summary>
        /// Mã quy trình sản phẩm
        /// </summary>
        /// 
        [Key]
        public string MaQuyTrinhSanPham { get; set; }
        public int STT { get; set; }
        public string MaSanPham { get; set; }
        public string TenQuyTrinh { get; set; }
    }
}
