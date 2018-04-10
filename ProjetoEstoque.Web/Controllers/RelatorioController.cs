using System.Web.Mvc;

namespace ProjetoEstoque.Web.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }
        [Authorize]
        public ActionResult Ressuprimento()
        {
            return View();
        }
    }
}