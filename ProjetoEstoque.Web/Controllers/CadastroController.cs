using ProjetoEstoque.Query;
using ProjetoEstoque.Query.Handler;
using ProjetoEstoque.Query.Result;
using ProjetoEstoque.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProjetoEstoque.Web.Controllers
{
    public class CadastroController : BaseController
    {
        readonly IQueryHandler<ObterGrupoProdutoQuery, IEnumerable<ObterGrupoProdutoQueryResult>> obterGrupoProdutoQueryHandler;

        public CadastroController(IQueryHandler<ObterGrupoProdutoQuery, IEnumerable<ObterGrupoProdutoQueryResult>> obterGrupoProdutoQueryHandler)
        {
            this.obterGrupoProdutoQueryHandler = obterGrupoProdutoQueryHandler;
        }

        [Authorize]
        public ActionResult GrupoProduto()
        {
            var result = obterGrupoProdutoQueryHandler.Handle(new ObterGrupoProdutoQuery(0)).Select(t => new GrupoProdutoViewModel {
                Nome = t.Nome,
                Ativo = t.Ativo

            });
            return View(result);
        }
        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }
        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }
        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }
        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }
        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }
        [Authorize]
        public ActionResult Perfil()
        {
            return View();
        }
        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}