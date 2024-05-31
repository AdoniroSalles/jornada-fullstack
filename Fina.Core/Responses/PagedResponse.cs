using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public class PagedResponse<TData>: Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(TData? data, int totalCount, int currentPage = 1, int pageSize = Configuration.DefaultPageSize) : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentePage = currentPage;
            PageSize = pageSize;
        }
        public int CurrentePage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize); // arredonda pra cima
        public int PageSize { get; set; } = Configuration.DefaultPageSize;
        public int TotalCount { get; set; }
    }
}
