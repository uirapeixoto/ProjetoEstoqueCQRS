using ProjetoEstoque.Query.Handler;
using ProjetoEstoque.Query.Public;
using ProjetoEstoque.Query.Public.Result;
using ProjetoEstoque.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjetoEstoque.Web.Controllers.Api
{
    public class EstadoController : ApiController
    {
        public readonly IQueryHandler<ObterEstadoQuery, IEnumerable<ObterEstadosQueryResult>> ObterEstadosQueryHandler;

        public EstadoController(IQueryHandler<ObterEstadoQuery, IEnumerable<ObterEstadosQueryResult>> obterEstadosQueryHandler)
        {
            ObterEstadosQueryHandler = obterEstadosQueryHandler;
        }

        public IEnumerable<EstadoViewModel> GetAllEstados()
        {
            return ObterEstadosQueryHandler.Handle(new ObterEstadoQuery(0)).Select(t => new EstadoViewModel {
                 Id = t.Id,
                 Descricao = t.Nome,
                 Sigla = t.Sigla
            });
        }
    }
}
