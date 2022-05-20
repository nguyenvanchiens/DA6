using DA6.Core.Entities;
using DA6.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("vets")]
    public class Vest
    {
        /// <summary>
        /// mã vest
        /// </summary>
        /// 
        [Key]
        public Guid MaVest { get; set; }
        /// <summary>
        /// Mã chủng loại
        /// </summary>
        /// 
        public Guid MaCL { get; set; }
        /// <summary>
        /// Kiểu nẹp (Tròn, vuông)
        /// </summary>
        public string KieuNep { get; set; }
        /// <summary>
        /// Kiểu ve (Xuôi, Xếch)
        /// </summary>
        public string KieuVe { get; set; }
        /// <summary>
        /// Kiểu cổ (Đứng, Bẻ)
        /// </summary>
        public string KieuCo { get; set; }
        /// <summary>
        /// Kiểu túi ngực (khóa trần;Dán 1 viền; Dán 2 viền)
        /// </summary>
        public string KieuTuiNguc { get; set; }
        /// <summary>
        /// Kiểu túi sườn (ốp không nắp;Ốp có nắp;1 viền; 2 viền;Khóa có nắp;1 viền nắp;2 viền nắp)
        /// </summary>
        public string KieuTuiSuon { get; set; }
        /// <summary>
        /// Kiểu tay (Có tay; không có tay)
        /// </summary>
        public string KieuTay { get; set; }
        /// <summary>
        /// Kiểu thân trước (Bổ ngang; Bổ dọc)
        /// </summary>
        public string KieuThanTruoc { get; set; }
        /// <summary>
        /// Kiểu thân sau(Bổ ngang; Bổ dọc)
        /// </summary>
        public string KieuThanSau { get; set; }
        /// <summary>
        /// Dài áo
        /// </summary>
        public float DaiAo { get; set; }
        /// <summary>
        /// VÒng gấu
        /// </summary>
        public float VongGau { get; set; }
        /// <summary>
        /// Vòng ngực
        /// </summary>
        public float VongNguc { get; set; }
        /// <summary>
        /// Dài tay
        /// </summary>
        public float DaiTay { get; set; }

        /// <summary>
        /// Thành phần vải 
        /// </summary>
        public string ThanhPhanVai1 { get; set; }
        /// <summary>
        /// Khổ vải 1
        /// </summary>
        public float KhoVai1 { get; set; }
        /// <summary>
        /// Thành phần vải 2
        /// </summary>
        public string ThanhPhanVai2 { get; set; }
        /// <summary>
        /// Khổ vải 2
        /// </summary>
        public float KhoVai2 { get; set; }
        /// <summary>
        /// Thành phần vải 3
        /// </summary>
        public string ThanhPhanVai3 { get; set; }
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
