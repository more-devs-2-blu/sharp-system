using Microsoft.EntityFrameworkCore;
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
        public DbSet<Usuario> Usuarios { get; set; }

        #endregion
    }
}
