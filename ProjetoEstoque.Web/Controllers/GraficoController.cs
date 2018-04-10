using System.Web.Mvc;

namespace ProjetoEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult PerdaMes()
        {
            return View();
        }

        [Authorize]
        public ActionResult EntradaSaidaMes() => View();
    }
}