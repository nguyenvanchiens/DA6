using System.ComponentModel.DataAnnotations;
using DA6.Core.Entities;
namespace DA6.Api.Entities
{
    public class ThanhPhanVai:BaseClass
    {
        [Key]
        public string MaThanhPhanVai { get; set; }
        public string TenThanhPhanVai { get; set; }
    }
}
