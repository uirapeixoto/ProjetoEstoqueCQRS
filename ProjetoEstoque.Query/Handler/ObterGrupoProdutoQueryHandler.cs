using ProjetoEstoque.Query.Result;
using System.Collections.Generic;

namespace ProjetoEstoque.Query.Handler
{
    public class ObterGrupoProdutoQueryHandler : IQueryHandler<ObterGrupoProdutoQuery, IEnumerable<ObterGrupoProdutoQueryResult> >
    {
        public ObterGrupoProdutoQueryHandler()
        {
        }

        public IEnumerable<ObterGrupoProdutoQueryResult> Handle(ObterGrupoProdutoQuery query)
        {
            return new List<ObterGrupoProdutoQueryResult>
            {
                new ObterGrupoProdutoQueryResult(1, "Livros", true),
                new ObterGrupoProdutoQueryResult(2, "Mouses", true),
                new ObterGrupoProdutoQueryResult(3, "Monitores", true)
            };
        }
    }
}
