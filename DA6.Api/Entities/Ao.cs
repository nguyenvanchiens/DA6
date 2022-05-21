using DA6.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DA6.Core.Enums.EnumsAo;

namespace DA6.Core.Entities
{
    [Table("aos")]
    public class Ao : BaseClass
    {
        /// <summary>
        /// Mã áo
        /// </summary>
        /// 
        [Key]
        public string MaA { get; set; }
        /// <summary>
        /// Mã chủng loại
        /// </summary>
        /// 
        public string MaCL { get; set; }
        /// <summary>
        /// Kiểu tay (ngắn, dài, không tay, bổ dọc, bổ ngang)
        /// </summary>
        public string KieuTay { get; set; }
        /// <summary>
        /// Kiểu cửa tay
        /// </summary>
        public string KieuCuaTay { get; set; }
        /// <summary>
        /// Kiểu gấu
        /// </summary>
        public string KieuGau { get; set; }
        /// <summary>
        /// Kiểu cổ
        /// </summary>
        public string KieuCo { get; set; }
        /// <summary>
        /// Kiểu túi
        /// </summary>
        public string KieuTui { get; set; }
        /// <summary>
        /// Kiểu nẹp
        /// </summary>
        public string KieuNep { get; set; }
        /// <summary>
        /// Kiểu thân trước
        /// </summary>
        public string KieuThanTruoc { get; set; }
        /// <summary>
        /// Kiểu xẻ
        /// </summary>
        public string KieuXe { get; set; }
        /// <summary>
        /// Kiểu thân sau
        /// </summary>
        public string KieuThanSau { get; set; }
        /// <summary>
        /// Dài Áo
        /// </summary>
        public float DaiAo { get; set; }
        /// <summary>
        /// Dài tay
        /// </summary>
        public float DaiTay { get; set; }
        /// <summary>
        /// Vòng ngực
        /// </summary>
        public float VongNguc { get; set; }
        /// <summary>
        /// Vòng mông
        /// </summary>
        public float VongMong { get; set; }
        /// <summary>
        /// Thành phần vải 1
        /// </summary>
        public string ThanhPhanVai1 { get; set; }
        /// <summary>
        /// Trọng lượng vải 1
        /// </summary>
        public float TrongLuongVai1 { get; set; }
        /// <summary>
        /// Khổ vải 1
        /// </summary>
        public float KhoVai1 { get; set; }
        /// <summary>
        /// Thành phần vải 2
        /// </summary>
        public string ThanhPhanVai2 { get; set; }
        /// <summary>
        /// Trọng lượng vải 2
        /// </summary>
        public float TrongLuongVai2 { get; set; }
        /// <summary>
        /// Khố vải 2
        /// </summary>
        public float KhoVai2 { get; set; }
        /// <summary>
        /// Thành phần vải 3
        /// </summary>
        public string ThanhPhanVai3 { get; set; }
        /// <summary>
        /// Trọng lượng vải 3
        /// </summary>
        public float TrongLuongVai3 { get; set; }
        /// <summary>
        /// Khố vải 3
        /// </summary>
        public float KhoVai3 { get; set; }
        /// <summary>
        /// Số sản phẩm trên sơ đồ
        /// </summary>
        public int SoSanPhanTrenSoDo { get; set; }
        /// <summary>
        /// Số lao động trên dây truyền
        /// </summary>
        public int SoLaoDongTrenDayTruyen { get; set; }
        /// <summary>
        /// Mức lương kỳ vọng
        /// </summary>
        public float MucLuongKyVong { get; set; }
        /// <summary>
        /// Lợi nhuận
        /// </summary>
        public float LoiNhuanDuKien { get; set; }
        /// <summary>
        /// Phụ Phí
        /// </summary>
        public float PhuPhi { get; set; }
        /// <summary>
        /// Khoản phí khác
        /// </summary>
        public float KhoanPhiKhac { get; set; }

    }
}
