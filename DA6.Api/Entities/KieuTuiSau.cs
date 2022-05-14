using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTuiSau:BaseClass
    {
        [Key]
        public string MaKieuTuiSau { get; set; }
        public string TenKieuTuiSau { get; set; }
    }
}
