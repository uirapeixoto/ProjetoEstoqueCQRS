using Newtonsoft.Json;
using ProjetoEstoque.Query.Handler;
using ProjetoEstoque.Query.Public.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace ProjetoEstoque.Query.Public.Handler
{
    public class Estados
    {
        public int id { get; set; }
        public string codigo_uf { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }
    }
    public class ObterEstadosQueryHandler : IQueryHandler<ObterEstadoQuery, IEnumerable<ObterEstadosQueryResult>>
    {
        public IEnumerable<ObterEstadosQueryResult> Handle(ObterEstadoQuery query)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format("http://api.uira.com.br/public/estados/{0}", query.Id);
                var result = JsonConvert.DeserializeObject<List<Estados>>(client.GetStringAsync(url).Result);

                return result.AsParallel().Select(e => new ObterEstadosQueryResult(e.id, e.estado, e.uf)).ToList();
            }
        }
    }
}
