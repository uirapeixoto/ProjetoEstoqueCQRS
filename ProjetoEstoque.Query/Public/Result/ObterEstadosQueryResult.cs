using ProjetoEstoque.Query.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstoque.Query.Public.Result
{
    public class ObterEstadosQueryResult : IQueryResult
    {
        public ObterEstadosQueryResult(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public int Id { get; }
        public string Nome { get; }
        public string Sigla { get; }
    }
}
