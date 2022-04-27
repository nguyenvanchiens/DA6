using DA6.Api.Attributes;

namespace DA6.Api.ViewModel.ChungLoai
{
    public class ChungLoaiCreateVM
    {
        /// <summary>
        /// Mã chủng loại
        /// </summary>
        /// 
        [NotEmpty]
        [PropertyName("Mã chủng loại")]
        public Guid MaCL { get; set; }
        /// <summary>
        /// Tên chủng loại
        /// </summary>
        /// 
        [NotEmpty]
        [PropertyName("Tên chủng loại")]
        public string? Ten { get; set; }
        /// <summary>
        /// Mô tả chủng loại
        /// </summary>
        public string? MoTa { get; set; }
        /// <summary>
        /// Kiểu chúng loại (Ao (Sơ mi, TShirt, Polo); 
        /// Quan(Dài, Lỡ, Sooc); Jacket(Jaket 1 lớp, Jacket 1.5 lớp, 
        /// Jacket 2 lớp, jacket 2 lớp, jacket 3 lớp, jacket 5 lớp); 
        /// vest (Vest 1 lớp,Vest 1.5 lớp,Vest 2 lớp))
        /// </summary>
        public string Kieu { get; set; }
    }
}
