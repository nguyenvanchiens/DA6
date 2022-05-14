using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTuiGoi:BaseClass
    {
        [Key]
        public string MaKieuTuiGoi { get; set; }
        public string TenKieuTuiGoi { get; set; }
    }
}
