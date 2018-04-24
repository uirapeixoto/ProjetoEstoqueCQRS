using ProjetoEstoque.Command.GrupoProduto.Result;
using ProjetoEstoque.Infra.Interface;

namespace ProjetoEstoque.Command.GrupoProduto.Handler
{
    public class SalvarGrupoProdutoCommandHandler : ICommandHandler<SalvarGrupoProdutoCommand, SalvarGrupoPrudutoCommandResult>
    {
        private readonly IControleEstoqueContext context;

        public SalvarGrupoProdutoCommandHandler(IControleEstoqueContext context)
        {
            this.context = context;
        }
        public SalvarGrupoPrudutoCommandResult Handle(SalvarGrupoProdutoCommand command)
        {
            var obj = context.TB_GRUPO_PRODUTO.Find(command.Id);

            if (obj!=null)
            {
                obj.NOME = command.NomeGrupo;
                obj.ATIVO = command.Ativo;
            }
            else
            {
                context.TB_GRUPO_PRODUTO.Add(new Infra.ControleEstoque.TB_GRUPO_PRODUTO
                {
                    NOME = command.NomeGrupo,
                    ATIVO = command.Ativo
                });
            }

            var result = context.SaveChanges();

            return new SalvarGrupoPrudutoCommandResult(1, "Teste", true);
            
        }
        
    }
}
