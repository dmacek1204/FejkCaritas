using System.Collections;

namespace FejkCaritas2.Views
{
    public class FilterResponse
    {
        public IEnumerable data { get; set; }
        public int totalCount { get; set; }
    }
}