using Microsoft.EntityFrameworkCore;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.Entities.NF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using SharpSystem.Domain.DTO;

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

            /*modelBuilder.Entity<NotaFiscal>()
            .HasData(
                    new { Id = 1, ValorTotal = "150,00", PrestadorId = 1, TomadorId = 1, ItensId = 1 }
                    );

            modelBuilder.Entity<Prestador>()
            .HasData(
                    new { Id = 1, CpfCnpj = "115.187.919-10", Cidade = "Blumenau" }
                    );

            modelBuilder.Entity<Tomador>()
            .HasData(
                    new { Id = 1, Tipo = "1", CpfCnpj = "12.345.678/0001-00", NomeRazaoSocial = "Empresa teste", Logradouro = "Oscar Wippel", Email = "teste@gmail.com", NumeroResidencia = "123", Bairro = "Agua Verde", Cidade = "Blumenau", Cep = "89062712" }
                    );

            modelBuilder.Entity<Itens>()
            .HasData(
                    new { Id = 1, ListaId = 1 }
                    );

            modelBuilder.Entity<Lista>()
            .HasData(
                    new { Id = 1, TributaMunicipioPrestador = "10", CodigoLocalPrestacaoServico = "12", CodigoItemListaServico = "94", Descritivo = "teste bla bla", AliquotaItemListaServico = "0", SituacaoTributaria = "0", ValorTributavel = "0" }
                    );*/
        }

        #region DbSets<Tables>
        public DbSet<Usuario> Usuarios { get; set; }
        /*public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Tomador> Tomadores { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Lista> Listas { get; set; }*/
        #endregion
    }
}
