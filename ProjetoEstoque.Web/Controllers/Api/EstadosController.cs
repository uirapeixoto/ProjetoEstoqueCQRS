using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjetoEstoque.Infra.ControleEstoque;
using ProjetoEstoque.Query.Handler;
using ProjetoEstoque.Query.Public;
using ProjetoEstoque.Query.Public.Result;
using ProjetoEstoque.Web.ViewModels;

namespace ProjetoEstoque.Web.Controllers.Api
{
    public class EstadosController : ApiController
    {
        private ControleEstoqueContext db = new ControleEstoqueContext();

        public readonly IQueryHandler<ObterEstadoQuery, IEnumerable<ObterEstadosQueryResult>> ObterEstadosQueryHandler;

        public EstadosController(IQueryHandler<ObterEstadoQuery, IEnumerable<ObterEstadosQueryResult>> obterEstadosQueryHandler)
        {
            ObterEstadosQueryHandler = obterEstadosQueryHandler;
        }

        // GET: api/Estados
        public IEnumerable<EstadoViewModel> GetEstadoViewModels()
        {
            return ObterEstadosQueryHandler.Handle(new ObterEstadoQuery(0)).Select(t => new EstadoViewModel
            {
                Id = t.Id,
                Descricao = t.Nome,
                Sigla = t.Sigla
            });
        }

        // GET: api/Estados/5
        [ResponseType(typeof(EstadoViewModel))]
        public async Task<IHttpActionResult> GetEstadoViewModel(int id)
        {
            var result = ObterEstadosQueryHandler.Handle(new ObterEstadoQuery(0)).Select(t => new EstadoViewModel
            {
                Id = t.Id,
                Descricao = t.Nome,
                Sigla = t.Sigla
            });
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}