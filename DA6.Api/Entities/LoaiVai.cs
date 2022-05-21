using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA6.Api.Entities
{
    [Table("loaivais")]
    /// <summary>
    /// Loại vải
    /// </summary>
    public class LoaiVai
    {
        [Key]
        public string MaVai { get; set; }
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
