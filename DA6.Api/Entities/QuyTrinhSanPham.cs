using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class QuyTrinhSanPham: BaseClass
    {
        /// <summary>
        /// Mã quy trình sản phẩm
        /// </summary>
        /// 
        [Key]
        public Guid MaQuyTrinhSanPham { get; set; }
        public int STT { get; set; }
        public Guid MaSanPham { get; set; }
        public string TenQuyTrinh { get; set; }
    }
}
