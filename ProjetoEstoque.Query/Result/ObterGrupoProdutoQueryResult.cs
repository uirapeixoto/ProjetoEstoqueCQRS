namespace ProjetoEstoque.Query.Result
{
    sealed public class ObterGrupoProdutoQueryResult : IQueryResult
    {
        public int Id { get; }
        public string Nome { get; }
        public bool Ativo { get; }

        public ObterGrupoProdutoQueryResult(int id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
            Ativo = ativo;
        }
    }
}
