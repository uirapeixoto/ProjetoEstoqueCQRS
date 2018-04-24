namespace ProjetoEstoque.Infra.ControleEstoque
{
    using ProjetoEstoque.Infra.Interface;
    using System.Data.Entity;

    public partial class ControleEstoqueContext : DbContext, IControleEstoqueContext
    {
        public ControleEstoqueContext()
            : base("name=ControleEstoqueContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<TB_FORNECEDOR> TB_FORNECEDOR { get; set; }
        public virtual DbSet<TB_GRUPO_PRODUTO> TB_GRUPO_PRODUTO { get; set; }
        public virtual DbSet<TB_LOCAL_ARMAZENAMENTO> TB_LOCAL_ARMAZENAMENTO { get; set; }
        public virtual DbSet<TB_MARCA_PRODUTO> TB_MARCA_PRODUTO { get; set; }
        public virtual DbSet<TB_PERFIL> TB_PERFIL { get; set; }
        public virtual DbSet<TB_PERFIL_USUARIO> TB_PERFIL_USUARIO { get; set; }
        public virtual DbSet<TB_PRODUTO> TB_PRODUTO { get; set; }
        public virtual DbSet<TB_UNIDADE_MEDIDA> TB_UNIDADE_MEDIDA { get; set; }
        public virtual DbSet<TB_USUARIO> TB_USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.NUM_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .HasMany(e => e.TB_PRODUTO)
                .WithRequired(e => e.TB_FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .HasMany(e => e.TB_PRODUTO1)
                .WithRequired(e => e.TB_FORNECEDOR1)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_FORNECEDOR>()
                .HasMany(e => e.TB_PRODUTO2)
                .WithRequired(e => e.TB_FORNECEDOR2)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_GRUPO_PRODUTO>()
                .HasMany(e => e.TB_PRODUTO)
                .WithRequired(e => e.TB_GRUPO_PRODUTO)
                .HasForeignKey(e => e.ID_GRUPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_GRUPO_PRODUTO>()
                .HasMany(e => e.TB_PRODUTO1)
                .WithRequired(e => e.TB_GRUPO_PRODUTO1)
                .HasForeignKey(e => e.ID_GRUPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_LOCAL_ARMAZENAMENTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_LOCAL_ARMAZENAMENTO>()
                .HasMany(e => e.TB_PRODUTO)
                .WithRequired(e => e.TB_LOCAL_ARMAZENAMENTO)
                .HasForeignKey(e => e.ID_LOCAL_ARMAZENAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MARCA_PRODUTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_MARCA_PRODUTO>()
                .HasMany(e => e.TB_PRODUTO)
                .WithRequired(e => e.TB_MARCA_PRODUTO)
                .HasForeignKey(e => e.ID_MARCA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_MARCA_PRODUTO>()
                .HasMany(e => e.TB_PRODUTO1)
                .WithRequired(e => e.TB_MARCA_PRODUTO1)
                .HasForeignKey(e => e.ID_MARCA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PERFIL>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PERFIL>()
                .HasMany(e => e.TB_PERFIL_USUARIO)
                .WithRequired(e => e.TB_PERFIL)
                .HasForeignKey(e => e.ID_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PERFIL>()
                .HasMany(e => e.TB_PERFIL_USUARIO1)
                .WithRequired(e => e.TB_PERFIL1)
                .HasForeignKey(e => e.ID_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PERFIL>()
                .HasMany(e => e.TB_USUARIO)
                .WithRequired(e => e.TB_PERFIL)
                .HasForeignKey(e => e.ID_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PERFIL>()
                .HasMany(e => e.TB_USUARIO1)
                .WithRequired(e => e.TB_PERFIL1)
                .HasForeignKey(e => e.ID_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PERFIL>()
                .HasMany(e => e.TB_USUARIO2)
                .WithRequired(e => e.TB_PERFIL2)
                .HasForeignKey(e => e.ID_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PRODUTO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PRODUTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PRODUTO>()
                .Property(e => e.PRECO_CUSTO)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TB_PRODUTO>()
                .Property(e => e.PRECO_VENDA)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TB_UNIDADE_MEDIDA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UNIDADE_MEDIDA>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<TB_UNIDADE_MEDIDA>()
                .HasMany(e => e.TB_PRODUTO)
                .WithRequired(e => e.TB_UNIDADE_MEDIDA)
                .HasForeignKey(e => e.ID_UNIDADE_MEDIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_UNIDADE_MEDIDA>()
                .HasMany(e => e.TB_PRODUTO1)
                .WithRequired(e => e.TB_UNIDADE_MEDIDA1)
                .HasForeignKey(e => e.ID_UNIDADE_MEDIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_UNIDADE_MEDIDA>()
                .HasMany(e => e.TB_PRODUTO2)
                .WithRequired(e => e.TB_UNIDADE_MEDIDA2)
                .HasForeignKey(e => e.ID_UNIDADE_MEDIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_UNIDADE_MEDIDA>()
                .HasMany(e => e.TB_PRODUTO3)
                .WithRequired(e => e.TB_UNIDADE_MEDIDA3)
                .HasForeignKey(e => e.ID_UNIDADE_MEDIDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_USUARIO>()
                .HasMany(e => e.TB_PERFIL_USUARIO)
                .WithRequired(e => e.TB_USUARIO)
                .HasForeignKey(e => e.ID_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_USUARIO>()
                .HasMany(e => e.TB_PERFIL_USUARIO1)
                .WithRequired(e => e.TB_USUARIO1)
                .HasForeignKey(e => e.ID_USUARIO)
                .WillCascadeOnDelete(false);
        }
    }
}
