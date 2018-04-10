namespace ProjetoEstoque.Query
{
    sealed public class ObterGrupoProdutoQuery : IQuery
    {
        public int Id { get; }

        public ObterGrupoProdutoQuery(int id)
        {
            Id = id;
        }
    }
}
