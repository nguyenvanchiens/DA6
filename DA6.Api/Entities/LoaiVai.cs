namespace DA6.Api.Entities
{
    /// <summary>
    /// Loại vải
    /// </summary>
    public class LoaiVai
    {
        public Guid MaVai { get; set; }
        /// <summary>
        /// Tên vải (Bông 100%, bông 100%; TC 65-35; TC35-65; PVC Ryon Bambo)
        /// </summary>
        public string? TenVai { get; set; }
        public string ThanhPhan { get; set; }
        /// <summary>
        /// Chức năng (Dùng may ngoài, may lót)
        /// </summary>
        public string ChucNang { get; set; }
        public string MoTa { get; set; }
    }
}
