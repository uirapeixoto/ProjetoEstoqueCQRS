using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstoque.Command.GrupoProduto
{
    public class RemoverGrupoProdutoCommand : ICommand
    {
        public int Id { get; set; }

        public RemoverGrupoProdutoCommand(int id)
        {
            Id = id;
        }
    }
}
