namespace DA6.Core.Enums
{
    #region Enums Áo
    public class EnumsAo
    {
        /// <summary>
        /// Kiểu tay
        /// </summary>
        public enum KieuTay
        {
            /// <summary>
            /// Ngắn thường
            /// </summary>
            NganThuong,
            /// <summary>
            /// Ngắn jaclan
            /// </summary>
            NganJaclan,
            /// <summary>
            /// Dài thường
            /// </summary>
            DaiThuong,
            /// <summary>
            /// Dài jaclan
            /// </summary>
            DaiJaclan,
            /// <summary>
            /// Không tay
            /// </summary>
            KhongTay

        }
        /// <summary>
        /// Kiểu cửa tay
        /// </summary>
        public enum KieuCuaTay
        {
            /// <summary>
            /// Thường
            /// </summary>
            Thuong,
            /// <summary>
            /// Viền
            /// </summary>
            Vien,
            /// <summary>
            /// Bo
            /// </summary>
            Bo
        }
        /// <summary>
        /// Kiểu gấu
        /// </summary>
        public enum KieuGau
        {
            /// <summary>
            /// Gấu Bo
            /// </summary>
            Bo,
            /// <summary>
            /// Gấu thường
            /// </summary>
            Thuong
        }
        /// <summary>
        /// Kiểu théo tay
        /// </summary>
        public enum KieuCo
        {
            /// <summary>
            /// Cổ bo
            /// </summary>
            CoBo,
            /// <summary>
            /// Cổ viền
            /// </summary>
            CoVien,
            /// <summary>
            /// Cổ có đáp
            /// </summary>
            CoCoDap,
            /// <summary>
            /// Cổ tàu
            /// </summary>
            CoTau,
            /// <summary>
            /// Cổ nam không chân(bo)
            /// </summary>
            CoNamKhongChan_Bo,
            /// <summary>
            /// Cổ nam không chân(vải chính)
            /// </summary>
            CoNamKhongChan_VaiChinh,
            /// <summary>
            /// Cổ nam có chân
            /// </summary>
            CoNamCoChan

        }
        /// <summary>
        /// Kiểu túi
        /// </summary>
        public enum KieuTui
        {
            /// <summary>
            /// Túi ốp không nắp
            /// </summary>
            TuiOpKhongNap,
            /// <summary>
            /// Túi bổ
            /// </summary>
            TuiBo,
            /// <summary>
            /// Túi ốp có nắp
            /// </summary>
            TuiOpCoNap,
        }
        /// <summary>
        /// Kiểu nẹp
        /// </summary>
        public enum KieuNep
        {
            /// <summary>
            /// Nẹp thường thuận
            /// </summary>
            NepThuongThuan,
            /// <summary>
            /// Nẹp thường nghịch
            /// </summary>
            NepThuongNghich,
            /// <summary>
            /// Nẹp liền thuận
            /// </summary>
            NepLienThuan,
            /// <summary>
            /// Nẹp liền nghịch
            /// </summary>
            NepLienNghich,
            /// <summary>
            /// Nẹp hộp
            /// </summary>
            NepHop,
            /// <summary>
            /// Không nẹp
            /// </summary>
            KhongNep
        }
        /// <summary>
        /// Kiểu thân trước
        /// </summary>
        public enum KieuThanTruoc
        {
            /// <summary>
            /// Bổ ngang
            /// </summary>
            BoNgang,
            /// <summary>
            /// Bổ dọc
            /// </summary>
            BoDoc,
            /// <summary>
            /// Bổ ngang và bổ dọc
            /// </summary>
            BoNgangVaBoDoc,
            /// <summary>
            /// Không bổ
            /// </summary>
            KhongBo
        }
        /// <summary>
        /// Kiểu xẻ
        /// </summary>
        public enum KieuXe
        {
            /// <summary>
            /// Xẻ sườn
            /// </summary>
            XeSuon,
            /// <summary>
            /// Không xẻ sườn
            /// </summary>
            KhongXeSuon
        }
        /// <summary>
        /// Kiểu Quần
        /// </summary>
        /// 
        /// <summary>
        /// Kiểu thân sau
        /// </summary>
        public enum KieuThanSau
        {
            /// <summary>
            /// Bổ dọc
            /// </summary>
            BoDoc,
            /// <summary>
            /// Bổ ngang
            /// </summary>
            BoNgang,
            /// <summary>
            /// Bổ ngang và bổ dọc
            /// </summary>
            BoNgangVaBoDoc,
            /// <summary>
            /// Không bổ
            /// </summary>
            KhongBo
        }

    }
    #endregion
    #region Enums Quần
    public class EnumsQuan
    {
        /// <summary>
        /// Kiểu quần
        /// </summary>
        public enum KieuQuan
        {
            /// <summary>
            /// Dài
            /// </summary>
            Dai,
            //Lỡ
            Lo,
            /// <summary>
            /// Sooc
            /// </summary>
            Sooc
        }
        /// <summary>
        /// Kiểu cạp
        /// </summary>
        public enum KieuCap
        {
            //Kiểu cạp (Liền; Rời;Chun sườn;Chun sau;liền có patxang; Rời có patxang)
            /// <summary>
            /// Liền
            /// </summary>
            Lien,
            /// <summary>
            /// Rời
            /// </summary>
            Roi,
            /// <summary>
            /// Chun sườn
            /// </summary>
            ChunSuon,
            /// <summary>
            /// Chun sau
            /// </summary>
            ChunSau,
            /// <summary>
            /// Liền có patxang
            /// </summary>
            LienCoPatXang,
            /// <summary>
            /// Rời có patxang
            /// </summary>
            RoiCoPatXang


        }

        /// <summary>
        /// Kiểu túi trước
        /// </summary>
        public enum KieuTuiTruoc
        {
            /// <summary>
            /// Dọc
            /// </summary>
            Doc,
            /// <summary>
            /// Chéo
            /// </summary>
            Cheo,
            /// <summary>
            /// Hàm ếch
            /// </summary>
            HanEch,
            /// <summary>
            /// Một viền
            /// </summary>
            MotVien,
            /// <summary>
            /// Hai viền khóa trần
            /// </summary>
            HaiVienKhoaTran,
            /// <summary>
            /// Một viền khóa
            /// </summary>
            MotVienKhoa,
            /// <summary>
            /// Hai viền khóa
            /// </summary>
            HaiVienKhoa
        }
        /// <summary>
        /// Kiểu túi sau
        /// </summary>
        public enum KieuTuiSau
        {
            /// <summary>
            /// Ốp không lắp
            /// </summary>
            OpKhongNap,
            /// <summary>
            /// Ốp có nắp
            /// </summary>
            OpCoNap,
            /// <summary>
            /// Hộp có nắp
            /// </summary>
            HopCoNap,
            /// <summary>
            /// Hộp không nắp
            /// </summary>
            HopKhongNap,
            /// <summary>
            /// Một viền
            /// </summary>
            MotVien,
            /// <summary>
            /// Hai viền
            /// </summary>
            HaiVien,
            /// <summary>
            /// Khóa trần
            /// </summary>
            KhoaTran,
            /// <summary>
            /// Một viền khóa
            /// </summary>
            MotVienKhoa,
            /// <summary>
            /// Hai viền khóa
            /// </summary>
            HaiVienKhoa
        }
        /// <summary>
        /// Kiểu tú gối
        /// </summary>
        public enum KieuTuiGoi
        {
            //Kiểu tú gối (ốp không nắp;Ốp có nắp;Hộp có nắp;Hộp không nắp;1 viền;2 viền;Khóa trần;1 viền khóa;2 viền khóa;)
            /// <summary>
            /// Ốp không nắp
            /// </summary>
            OpKhongNap,
            /// <summary>
            /// Ốp có nắp
            /// </summary>
            OpCoNap,
            /// <summary>
            /// Hộp có nắp
            /// </summary>
            HopCoNap,
            /// <summary>
            /// Hộp không nắp
            /// </summary>
            HopKhongNap,
            /// <summary>
            /// Một viền
            /// </summary>
            MotVien,
            /// <summary>
            /// Hai viền
            /// </summary>
            HaiVien,
            /// <summary>
            /// Khóa trần
            /// </summary>
            KhoaTran,
            /// <summary>
            /// Một viền khóa
            /// </summary>
            MotVienKhoa,
            /// <summary>
            /// Hai viền khóa
            /// </summary>
            HaiVienKhoa
        }
        /// <summary>
        /// Kiểu cửa quần
        /// </summary>
        public enum KieuCuaQuan
        {
            /// <summary>
            /// Đáp liền
            /// </summary>
            DapLien,
            /// <summary>
            /// Đáp rời
            /// </summary>
            DapRoiCoKhoa,
            /// <summary>
            /// Đáp rời cúc
            /// </summary>
            DapRoiCuc,
        }
    }
    #endregion
    /// <summary>
    /// Thành phần vải
    /// </summary>
    public enum ThanhPhanVai
    {
        /// <summary>
        /// Bông 100%
        /// </summary>
        Bong100,
        /// <summary>
        /// TC 65-35
        /// </summary>
        TC65_35,
        /// <summary>
        /// TC 35-65
        /// </summary>
        TC35_65,
        /// <summary>
        /// Pes 100%
        /// </summary>
        PES100,
        /// <summary>
        /// Ryon
        /// </summary>
        Ryon,
        /// <summary>
        /// Bambo
        /// </summary>
        Bambo
    }

}
