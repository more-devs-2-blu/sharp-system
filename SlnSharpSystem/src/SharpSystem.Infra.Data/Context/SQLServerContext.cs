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
<<<<<<< HEAD
    public class SQLServerContext : DbContext   
=======
    public class SQLServerContext : DbContext
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
            .HasData(
                    new { Id = 1, Nome = "Pedro Godri", CFPCNPJ = "104.752.299-23", Email = "pedrogodri@gmail.com", Login = "PedroGodri", Senha = "12345" }
                    );

<<<<<<< HEAD
            /*modelBuilder.Entity<NotaFiscal>()
            .HasData(
                    new { Id = 1, ValorTotal = "150,00", PrestadorId = 1, TomadorId = 1, ItensId = 1 }
=======
            modelBuilder.Entity<NotaFiscal>()
                .HasOne(prestador => prestador.prestador).WithMany(n => n.NotaFiscal)
                .HasForeignKey(notaFiscal => notaFiscal.PrestadorId);

            modelBuilder.Entity<NotaFiscal>()
                 .HasOne(tomador => tomador.tomador).WithMany(n => n.NotaFiscal)
                .HasForeignKey(notaFiscal => notaFiscal.TomadorId);

            modelBuilder.Entity<NotaFiscal>()
                   .HasOne(item => item.itens).WithMany(n => n.NotaFiscal)
                .HasForeignKey(notaFiscal => notaFiscal.ItemId);

            modelBuilder.Entity<Itens>()
                .HasOne(itens => itens.Lista)
                .WithMany(lista => lista.Itens)
                .HasForeignKey(itens => itens.listaId);

            modelBuilder.Entity<NotaFiscal>()
            .HasData(
                    new { Id = 1, ValorTotal = "150,00", PrestadorId = 1, TomadorId = 1, ItemId = 1 }
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
                    );

            modelBuilder.Entity<Prestador>()
            .HasData(
<<<<<<< HEAD
                    new { Id = 1, CpfCnpj = "115.187.919-10", Cidade = "Blumenau" }
=======
                    new { Id = 1, CpfCnpj = "115.187.919-10", Cidade = "8357" }
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
                    );

            modelBuilder.Entity<Tomador>()
            .HasData(
<<<<<<< HEAD
                    new { Id = 1, Tipo = "1", CpfCnpj = "12.345.678/0001-00", NomeRazaoSocial = "Empresa teste", Logradouro = "Oscar Wippel", Email = "teste@gmail.com", NumeroResidencia = "123", Bairro = "Agua Verde", Cidade = "Blumenau", Cep = "89062712" }
=======
                    new { Id = 1, Tipo = "J", CpfCnpj = "12.345.678/0001-00", NomeRazaoSocial = "Empresa teste", Logradouro = "Oscar Wippel", Email = "teste@gmail.com", NumeroResidencia = "123", Bairro = "Agua Verde", Cidade = "8357", Cep = "89062712" }
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
                    );

            modelBuilder.Entity<Itens>()
            .HasData(
<<<<<<< HEAD
                    new { Id = 1, ListaId = 1 }
=======
                    new { Id = 1, listaId = 1 }
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
                    );

            modelBuilder.Entity<Lista>()
            .HasData(
<<<<<<< HEAD
                    new { Id = 1, TributaMunicipioPrestador = "10", CodigoLocalPrestacaoServico = "12", CodigoItemListaServico = "94", Descritivo = "teste bla bla", AliquotaItemListaServico = "0", SituacaoTributaria = "0", ValorTributavel = "0" }
                    );*/
=======
                    new { Id = 1, TributaMunicipioPrestador = "10", CodigoLocalPrestacaoServico = "12", CodigoItemListaServico = "94", Descritivo = "teste bla bla", AliquotaItemListaServico = "5,0", SituacaoTributaria = "0", ValorTributavel = "1,0" }
                    );
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
        }

        #region DbSets<Tables>
        public DbSet<Usuario> Usuarios { get; set; }
<<<<<<< HEAD
        /*public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Tomador> Tomadores { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Lista> Listas { get; set; }*/
        #endregion
    }
}
=======
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Prestador> Prestadores { get; set; }
        public DbSet<Tomador> Tomadores { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Lista> Listas { get; set; }
        #endregion
    }
}
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
