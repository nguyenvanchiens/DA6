using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("quytrinhchitiets")]
    public class QuyTrinhChiTiet: BaseClass
    {
        /// <summary>
        /// Mã Quy Trinh Chi Tiet
        /// </summary>
        /// 
        [Key]
        public string MaQuyTrinhChiTiet { get; set; }
        public int STT { get; set; }
        /// <summary>
        /// Nội dung bước
        /// </summary>
        public string NoiDungBuoc { get; set; }
        /// <summary>
        /// Thiết bị
        /// </summary>
        public string ThietBi { get; set; }
        /// <summary>
        /// Bậc thợ
        /// </summary>
        public string BacTho { get; set; }
        /// <summary>
        /// Thời gian chế tạo
        /// </summary>
        public int ThoiGianCheTao { get; set; }
        /// <summary>
        /// Đơn giá
        /// </summary>
        public float DonGia { get; set; }
        /// <summary>
        /// Ghi Chú
        /// </summary>
        public string GhiChu { get; set; }
    }
}
