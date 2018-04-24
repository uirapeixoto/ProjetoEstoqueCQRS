namespace ProjetoEstoque.Infra.Public
{
    using ProjetoEstoque.Infra.Interface;
    using System.Data.Entity;

    public partial class PublicContext : DbContext, IPublicContext
    {
        public PublicContext()
            : base("name=PublicContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estados>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Estados>()
                .Property(e => e.UF)
                .IsUnicode(false);

            modelBuilder.Entity<Estados>()
                .HasMany(e => e.Municipios)
                .WithRequired(e => e.Estados)
                .HasForeignKey(e => e.Estado_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Municipios>()
                .Property(e => e.Municipio)
                .IsUnicode(false);
        }
    }
}
