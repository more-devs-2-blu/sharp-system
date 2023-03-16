using Microsoft.EntityFrameworkCore;
using SharpSystem.Domain.Entities.NFS;
using SharpSystem.Domain.Entities.Usuario;

namespace SharpSystem.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #region DbSets<Tables>
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Lista> Listas { get; set; }
        public DbSet<NFSE> NFSEs { get; set; }
        public DbSet<NotaFiscal> NotaFiscals { get; set; }
        public DbSet<Prestador> Prestador { get; set; }
        public DbSet<Tomador> Tomador { get; set; }
        #endregion
    }
}
