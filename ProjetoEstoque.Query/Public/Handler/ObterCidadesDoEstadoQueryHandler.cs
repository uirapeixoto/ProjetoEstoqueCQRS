using Newtonsoft.Json;
using ProjetoEstoque.Query.Handler;
using ProjetoEstoque.Query.Public.Result;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace ProjetoEstoque.Query.Public.Handler
{
    public class Municipios
    {
        public int id { get; set; }
        public string municipio { get; set; }
    }

    public class ObterCidadesDoEstadoQueryHandler : IQueryHandler<ObterCidadesDoEstadoQuery, IEnumerable<ObterCidadesDoEstadoQueryResult>>
    {
        public IEnumerable<ObterCidadesDoEstadoQueryResult> Handle(ObterCidadesDoEstadoQuery query)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format("http://api.uira.com.br/public/estado/get-municipios/{0}", query.IdEstado);
                var result = JsonConvert.DeserializeObject<List<Municipios>>(client.GetStringAsync(url).Result);

                return result.AsParallel().Select(t => new ObterCidadesDoEstadoQueryResult(t.id, t.municipio)).ToList();
            }
        }
    }
}
