using ProjetoEstoque.Infra.Interface;
using System;
using System.Linq;

namespace ProjetoEstoque.Command.GrupoProduto.Handler
{
    public class RemoverGrupoProdutoCommandHandler : ICommandHandler<RemoverGrupoProdutoCommand>
    {
        private readonly IControleEstoqueContext context;

        public RemoverGrupoProdutoCommandHandler(IControleEstoqueContext context)
        {
            this.context = context;
        }

        private void BusinessValidations(RemoverGrupoProdutoCommand command)
        {
            if(!context.TB_GRUPO_PRODUTO.AsNoTracking().Any(x => x.ID == command.Id))
            {
                throw new Exception("Registro não encontrado");
            }

        }
        public void Handle(RemoverGrupoProdutoCommand command)
        {
            BusinessValidations(command);

            var record = context.TB_GRUPO_PRODUTO.Find(command.Id);
            record.ATIVO = false;
            context.SaveChanges();
        }
    }
}
