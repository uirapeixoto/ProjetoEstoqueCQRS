using ProjetoEstoque.Query.Result;

namespace ProjetoEstoque.Query.Public.Result
{
    public class ObterCidadesDoEstadoQueryResult : IQueryResult
    {
        public ObterCidadesDoEstadoQueryResult(int id, string cidade)
        {
            Id = id;
            Cidade = cidade;
        }

        public int Id { get; }
        public string Cidade { get; }
    }
}
