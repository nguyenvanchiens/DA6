using DA6.Core.Entities;

namespace DA6.Api.ViewModel.Response
{
    public class ResponseSelect
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public string GroupLabel { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}
