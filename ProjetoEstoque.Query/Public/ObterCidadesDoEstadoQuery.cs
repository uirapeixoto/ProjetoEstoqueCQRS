namespace ProjetoEstoque.Query.Public
{
    public class ObterCidadesDoEstadoQuery : IQuery
    {
        public ObterCidadesDoEstadoQuery(int idEstado)
        {
            IdEstado = idEstado;
        }

        public int IdEstado { get; }
    }
}
