using DA6.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class DaiQuan: BaseClass
    {
        [Key]
        public string MaDaiQuan { get; set; }
        public string TenDaiQuan { get; set; }
    }
}
