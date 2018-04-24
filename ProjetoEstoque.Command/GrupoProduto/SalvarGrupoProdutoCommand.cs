using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstoque.Command.GrupoProduto
{
    public class SalvarGrupoProdutoCommand : ICommand
    {
        public int Id;
        public string NomeGrupo { get; }
        public bool Ativo { get; }

        public SalvarGrupoProdutoCommand(int id, string nomeGrupo, bool ativo)
        {
            this.Id = id;
            this.NomeGrupo = nomeGrupo;
            this.Ativo = ativo;
        }
    }
}
