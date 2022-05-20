using DA6.Core.Entities;
using DA6.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("jackets")]
    public class JacKet
    {
        [Key]
        public Guid MaJket { get; set; }
        /// <summary>
        /// Mã chủng loại
        /// </summary>
        /// 
        public Guid MaCL { get; set; }
        /// <summary>
        /// Ruột bằng bông/bằng lông (Lông vũ; Bông vón; Bông tấm)
        /// </summary>
        public string Ruot { get; set; }
        /// <summary>
        /// Kiểu chần (Ngang;Dọc;Ô vuông Trám;Khác)
        /// </summary>
        public string KieuChan { get; set; }
        /// <summary>
        /// Kiểu gấu (Bó, Đai, Suông)
        /// </summary>
        public string KieuGau { get; set; }
        /// <summary>
        /// Kiểu mũ (2 mảnh rời cúc;3 mảnh rời
        /// 2 mảnh liền;2 mảnh rời khóa
        /// 3 mảnh rời khóa;3 mảnh rời cúc)
        /// </summary>
        public string KieuMu { get; set; }
        /// <summary>
        /// Kiểu cổ (Cổ đứng;Cổ bẻ;Cổ pilot Không cổ)
        /// </summary>
        public string KieuCo { get; set; }
        /// <summary>
        /// Kiểu túi ngực (ốp không nắp;Ốp có nắp;Hộp có nắp;Hộp không nắp;1 viền;2 viền;Khóa trần;1 viền khóa;2 viền khóa;)
        /// </summary>
        public string KieuTuiNguc { get; set; }
        /// <summary>
        /// Kiểu túi sườn (ốp không nắp;Hộp không nắp; 1 viền;2 viền;Khóa trần;1 viền khóa;2 viền khóa;)
        /// </summary>
        public string KieuTuiSuon { get; set; }
        /// <summary>
        /// Kiểu khóa nẹp (Các dạng hình ảnh)
        /// </summary>
        public string KieuKhoaNep { get; set; }
        /// <summary>
        /// Kiểu tay (Bổ ngang;Bổ dọc;Bổ ngang +dọc)
        /// </summary>
        public string KieuTay { get; set; }
        /// <summary>
        /// Kiểu thân trước (Bổ ngang;Bổ dọc;Bổ ngang +dọc)
        /// </summary>
        public string KieuThanTruoc { get; set; }
        /// <summary>
        /// Dài áo
        /// </summary>
        public float DaiAo { get; set; }
        /// <summary>
        /// Vòng ngực
        /// </summary>
        public float VongNguc { get; set; }
        /// <summary>
        /// Dài tay
        /// </summary>
        public float DaiTay { get; set; }
        /// <summary>
        /// Thành phần vải chính 1 ((bông 100%; TC 65-35; TC35-65;PES 100%))
        /// </summary>
        public string ThanhPhanVaiChinh1 { get; set; }
        /// <summary>
        /// Khổ vải chính 1
        /// </summary>
        public float KhoVaiChinh1 { get; set; }
        /// <summary>
        /// Thành phần vải chính 2 ((bông 100%; TC 65-35; TC35-65;PES 100%))
        /// </summary>
        public string ThanhPhanVaiChinh2 { get; set; }
        /// <summary>
        /// Khổ vải chính 2
        /// </summary>
        public float KhoVaiChinh2 { get; set; }
        /// <summary>
        /// Thành phần vải chính 3 ((bông 100%; TC 65-35; TC35-65;PES 100%))
        /// </summary>
        public string ThanhPhanVaiChinh3 { get; set; }
        /// <summary>
        /// Khổ vải chính 3
        /// </summary>
        public float KhoVaiChinh3 { get; set; }
        /// <summary>
        /// Thành phần vải lót 1 ((bông 100%; TC 65-35; TC35-65;PES 100%))
        /// </summary>
        public string ThanhPhanVaiLot1 { get; set; }
        /// <summary>
        /// Khổ vải lót 1
        /// </summary>
        public float KhoVaiLot1 { get; set; }
        /// <summary>
        /// Thành phần vải lót 2 ((bông 100%; TC 65-35; TC35-65;PES 100%))
        /// </summary>
        public string ThanhPhanVaiLot2 { get; set; }
        /// <summary>
        /// Khổ vải lót 2
        /// </summary>
        public float KhoVaiLot2 { get; set; }
        /// <summary>
        /// Thành phần vải lót 3 ((bông 100%; TC 65-35; TC35-65;PES 100%))
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
