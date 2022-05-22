namespace DA6.Api.ViewModel.Files
{
    public class PagingRequest
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public string? textSearch { get; set; }
    }
}
