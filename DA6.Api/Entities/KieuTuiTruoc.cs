using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTuiTruoc:BaseClass
    {
        [Key]
        public string MaKieuTuiTruoc { get; set; }
        public string TenKieuTuiTruoc { get; set; }
    }
}
