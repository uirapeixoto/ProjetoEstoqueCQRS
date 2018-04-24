using ProjetoEstoque.Infra.Interface;
using ProjetoEstoque.Query.Result;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEstoque.Query.Handler
{
    public class ObterGrupoProdutoQueryHandler : IQueryHandler<ObterGrupoProdutoQuery, IEnumerable<ObterGrupoProdutoQueryResult> >
    {
        private readonly IControleEstoqueContext context;

        public ObterGrupoProdutoQueryHandler(IControleEstoqueContext context)
        {
            this.context = context;
        }

        public IEnumerable<ObterGrupoProdutoQueryResult> Handle(ObterGrupoProdutoQuery query)
        {
            return context.TB_GRUPO_PRODUTO
                .AsNoTracking()
                .Where(t => (query.Id == 0) || t.ID == query.Id)
                .AsParallel()
                .Select(r => new ObterGrupoProdutoQueryResult(
                   r.ID, r.NOME , r.ATIVO.Value
                )).ToList();
        }
    }
}
