namespace DA6.Core.Entities
{
    public class BaseClass
    {
        /// <summary>
        /// Người tạo
        /// </summary>

        public string? CreatedBy { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>

        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người sửa
        /// </summary>

        public string? ModifiedBy { get; set; }
        /// <summary>
        /// Ngày sửa
        /// </summary>

        public DateTime ModifiedDate { get; set; }
    }
}
