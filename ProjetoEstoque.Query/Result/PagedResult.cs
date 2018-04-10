using System.Collections.Generic;

namespace ProjetoEstoque.Query.Result
{
    public class PagedResult<T> : IQueryResult
    {
        public IEnumerable<T> Data { get; }

        public int Total { get; }

        public int AmountPages { get { return (Total + (Pagination.PageSize) - 1) / (Pagination.PageSize); } }

        public Pagination Pagination { get; }

        public PagedResult(IEnumerable<T> data, int total, Pagination pagination)
        {
            this.Data = data;
            this.Total = total;
            this.Pagination = pagination;
        }
    }
}
