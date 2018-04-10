using System.ComponentModel.DataAnnotations;

namespace ProjetoEstoque.Web.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name ="Usuario"), Required(ErrorMessage ="Inform o usuário")]
        public string Usuario { get; set; }
        [Display(Name = "Senha"), Required(ErrorMessage ="Informe a senha"), DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Lembrar-me")]
        public bool LembrarMe { get; set; }
    }
}