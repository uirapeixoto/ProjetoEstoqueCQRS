using ProjetoEstoque.Command;
using ProjetoEstoque.Command.GrupoProduto;
using ProjetoEstoque.Command.GrupoProduto.Result;
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
        private readonly IQueryHandler<ObterGrupoProdutoQuery, IEnumerable<ObterGrupoProdutoQueryResult>> obterGrupoProdutoQueryHandler;
        private readonly ICommandHandler<SalvarGrupoProdutoCommand, SalvarGrupoPrudutoCommandResult> salvarGrupoProdutoCommandHandler;

        public CadastroController(IQueryHandler<ObterGrupoProdutoQuery, IEnumerable<ObterGrupoProdutoQueryResult>> obterGrupoProdutoQueryHandler,
            ICommandHandler<SalvarGrupoProdutoCommand, SalvarGrupoPrudutoCommandResult> salvarGrupoProdutoCommandHandler)
        {
            this.obterGrupoProdutoQueryHandler = obterGrupoProdutoQueryHandler;
            this.salvarGrupoProdutoCommandHandler = salvarGrupoProdutoCommandHandler;
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
        [HttpPost]
        public ActionResult GrupoProduto(int id) => Json(obterGrupoProdutoQueryHandler.Handle(new ObterGrupoProdutoQuery(id)).Select(t => new GrupoProdutoViewModel
            {
                Nome = t.Nome,
                Ativo = t.Ativo

            }));

        [HttpPost]
        public ActionResult ExcluirGrupoProduto(int id)
        {
            return Json(id);
        }

        [HttpPost]
        public ActionResult SalvarGrupoProduto(int id, string nome, bool ativo)
        {
            var result = salvarGrupoProdutoCommandHandler.Handle(new SalvarGrupoProdutoCommand(id, nome, ativo));
            return Json(result);
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