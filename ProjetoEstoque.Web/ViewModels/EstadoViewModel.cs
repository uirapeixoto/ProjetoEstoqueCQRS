using System.Collections.Generic;

namespace ProjetoEstoque.Web.ViewModels
{
    public class EstadoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public List<CidadeViewModel> Cidades { get; set; }
    }
}