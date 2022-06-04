namespace DA6.Api.ViewModel.Common
{
    public class PageResult<T>
    {
        public List<T> items { get; set; }
        public int totalRecord { get; set; }
    }
}
