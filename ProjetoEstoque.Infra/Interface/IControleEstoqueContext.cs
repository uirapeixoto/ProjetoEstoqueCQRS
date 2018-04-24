using System;
using System.Data.Entity;
using ProjetoEstoque.Infra.ControleEstoque;

namespace ProjetoEstoque.Infra.Interface
{
    public interface IControleEstoqueContext : IDisposable
    {
        DbSet<TB_FORNECEDOR> TB_FORNECEDOR { get; set; }
        DbSet<TB_GRUPO_PRODUTO> TB_GRUPO_PRODUTO { get; set; }
        DbSet<TB_LOCAL_ARMAZENAMENTO> TB_LOCAL_ARMAZENAMENTO { get; set; }
        DbSet<TB_MARCA_PRODUTO> TB_MARCA_PRODUTO { get; set; }
        DbSet<TB_PERFIL> TB_PERFIL { get; set; }
        DbSet<TB_PERFIL_USUARIO> TB_PERFIL_USUARIO { get; set; }
        DbSet<TB_PRODUTO> TB_PRODUTO { get; set; }
        DbSet<TB_UNIDADE_MEDIDA> TB_UNIDADE_MEDIDA { get; set; }
        DbSet<TB_USUARIO> TB_USUARIO { get; set; }

        int SaveChanges();
    }
}
