using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class KieuTui:BaseClass
    {
        [Key]
        public string MaKieuTui { get; set; }
        public string TenKieuTui { get; set; }
    }
}
