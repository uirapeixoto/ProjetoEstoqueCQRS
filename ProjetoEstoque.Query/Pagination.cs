namespace ProjetoEstoque.Query
{
    sealed public class Pagination
    {
        public int PageSize { get; }
        public int PageNumber { get; }

        public Pagination(int pageSize, int pageNumber)
        {
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }
    }
}
