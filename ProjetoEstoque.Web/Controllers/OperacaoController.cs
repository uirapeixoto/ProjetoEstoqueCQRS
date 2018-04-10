using System.Web.Mvc;

namespace ProjetoEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public ActionResult EntradaEstoque() => View();
        [Authorize]
        public ActionResult SaidaEstoque() => View();
        [Authorize]
        public ActionResult LancPerdaProduto() => View();
        [Authorize]
        public ActionResult Operacao() => View();
    }
}