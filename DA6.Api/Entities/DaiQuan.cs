using System.ComponentModel.DataAnnotations;

namespace DA6.Api.Entities
{
    public class DaiQuan
    {
        [Key]
        public string MaDaiQuan { get; set; }
        public string TenDaiQuan { get; set; }
    }
}
