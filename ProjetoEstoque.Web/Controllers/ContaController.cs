using ProjetoEstoque.Web.ViewModels;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjetoEstoque.Web.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost, AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var achou = (login.Usuario == "uirapeixoto" && login.Senha == "uira123");

            if(achou)
            {
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login inválido");
            }

            return View();
        }
    }
}