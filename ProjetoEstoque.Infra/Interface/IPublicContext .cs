using ProjetoEstoque.Infra.Public;
using System;
using System.Data.Entity;

namespace ProjetoEstoque.Infra.Interface
{
    public interface IPublicContext : IDisposable
    {
        DbSet<Estados> Estados { get; set; }
        DbSet<Municipios> Municipios { get; set; }

        int SaveChanges();
    }
}
