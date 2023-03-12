using Microsoft.EntityFrameworkCore;
using SharpSystem.Domain.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Infra.Data.Context
{
    public class SQLServerContext : DbContext   
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
            .HasData(
                    new { Id = 1, Nome = "Pedro Godri", CFPCNPJ = "104.752.299-23", Email = "pedrogodri@gmail.com", Login = "PedroGodri", Senha = "12345" }
                    );
        }

        #region DbSets<Tables>
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion
    }
}
