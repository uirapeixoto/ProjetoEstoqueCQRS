namespace ProjetoEstoque.Query.Handler
{
    public interface IQueryHandler<in TQuery, out TQueryResult> where TQuery : IQuery
    {
        TQueryResult Handle(TQuery query);
    }
}
