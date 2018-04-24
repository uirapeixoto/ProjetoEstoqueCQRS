using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstoque.Query.Public
{
    public sealed class ObterEstadoQuery : IQuery
    {
        public ObterEstadoQuery(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
