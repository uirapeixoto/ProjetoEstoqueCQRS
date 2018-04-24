namespace ProjetoEstoque.Command.GrupoProduto.Result
{
    public class SalvarGrupoPrudutoCommandResult : ICommand
    {
        public int Id;
        public string NomeGrupo { get; }
        public bool Ativo { get; }

        public SalvarGrupoPrudutoCommandResult(int id, string nomeGrupo, bool ativo)
        {
            Id = id;
            NomeGrupo = nomeGrupo;
            Ativo = ativo;
        }
    }
}
