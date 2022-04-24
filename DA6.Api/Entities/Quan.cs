using DA6.Core.Entities;
using DA6.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DA6.Core.Enums.EnumsQuan;

namespace DA6.Api.Entities
{
    /// <summary>
    /// Quần
    /// </summary>
    public class Quan
    {
        /// <summary>
        /// Mã quần
        /// </summary>
        /// 
        [Key]
        public Guid MaQuan { get; set; }
        /// <summary>
        /// Mã chủng loại
        /// </summary>
        /// 
        [ForeignKey("MaCL")]
        public Guid MaCL { get; set; }
        public ChungLoai ChungLoai { get; set; }
        /// <summary>
        /// Kiểu quần (Dài; Lỡ; Sooc)
        /// </summary>
        public KieuQuan KieuQuan { get; set; }
        /// <summary>
        /// Kiểu cạp
        /// </summary>
        public KieuCap KieuCap { get; set; }
        /// <summary>
        /// Kiểu túi trước
        /// </summary>
        public KieuTuiTruoc KieuTuiTruoc { get; set; }
        /// <summary>
        /// Kiểu túi sau
        /// </summary>
        public KieuTuiSau KieuTuiSau { get; set; }
        /// <summary>
        /// Kiểu tú gối
        /// </summary>
        public KieuTuiGoi KieuTuiGoi { get; set; }
        /// <summary>
        /// Kiểu cửa quần
        /// </summary>
        public KieuCuaQuan KieuCuaQuan { get; set; }
        /// <summary>
        /// Kiểu thân trước (Bổ ngang;Bổ dọc;Bổ ngang và bổ dọc)
        /// </summary>
        public string KieuThanTruoc { get; set; }
        /// <summary>
        /// Kiểu thân sau  (Bổ ngang;Bổ dọc;Bổ ngang và bổ dọc)
        /// </summary>
        public string KieuThanSau { get; set; }
        /// <summary>
        /// Đai quần
        /// </summary>
        public string DaiQuan { get; set; }
        /// <summary>
        /// Vòng mông (cm)
        /// </summary>
        public float VongMong { get; set; }
        /// <summary>
        /// Vòng bụng (cm)
        /// </summary>
        public float VongBung { get; set; }
        /// <summary>
        /// Thành phần vải 
        /// </summary>
        public ThanhPhanVai ThanhPhanVai1 { get; set; }
        /// <summary>
        /// Khổ vải 1
        /// </summary>
        public float KhoVai1 { get; set; }
        /// <summary>
        /// Thành phần vải 2
        /// </summary>
        public ThanhPhanVai ThanhPhanVai2 { get; set; }
        /// <summary>
        /// Khổ vải 2
        /// </summary>
        public float KhoVai2 { get; set; }
        /// <summary>
        /// Thành phần vải 3
        /// </summary>
        public ThanhPhanVai ThanhPhanVai3 { get; set; }
        /// <summary>
        /// Khổ vải 3
        /// </summary>
        public float KhoVai3 { get; set; }
        /// <summary>
        /// Thành phần vải lót 1(bông 100%; TC 65-35; TC35-65;PES 100%)
        /// </summary>
        public string ThanhPhanVaiLot1 { get; set; }
        /// <summary>
        /// Khổ vải lót 1
        /// </summary>
        public float KhoVaiLot1 { get; set; }
        /// <summary>
        /// Thành phần vải lót 2(bông 100%; TC 65-35; TC35-65;PES 100%)
        /// </summary>
        public string ThanhPhanVaiLot2 { get; set; }
        /// <summary>
        /// Khổ vải lót 2
        /// </summary>
        public float KhoVaiLot2 { get; set; }
        /// <summary>
        /// Thành phần vải lót 3(bông 100%; TC 65-35; TC35-65;PES 100%)
        /// </summary>
        public string ThanhPhanVaiLot3 { get; set; }
        /// <summary>
        /// Khổ vải lót 3
        /// </summary>
        public float KhoVaiLot3 { get; set; }
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
