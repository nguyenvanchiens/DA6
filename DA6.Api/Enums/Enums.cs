namespace DA6.Core.Enums
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
