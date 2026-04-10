namespace Landscaping_WebApplication_API_.Model
{
    public class PagedResult<T>
    {
        public int PageIndex{  get; set; }
        public int PageSize {  get; set; }
        public int TotalCount { get; set; }
        public List<T> Items { get; set; }
    }
}
