﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpSystem.Infra.Data.Context;

#nullable disable

namespace SharpSystem.Infra.Data.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    [Migration("20230316033116_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.Itens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("listaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("listaId");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.Lista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AliquotaItemListaServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoItemListaServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoLocalPrestacaoServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descritivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacaoTributaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TributaMunicipioPrestador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorTributavel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Listas");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.NFSE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItensId")
                        .HasColumnType("int");

                    b.Property<int>("NotaFiscalId")
                        .HasColumnType("int");

                    b.Property<int>("PrestadorId")
                        .HasColumnType("int");

                    b.Property<int>("TomadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItensId");

                    b.HasIndex("NotaFiscalId");

                    b.HasIndex("PrestadorId");

                    b.HasIndex("TomadorId");

                    b.ToTable("NFSEs");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.NotaFiscal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ValorTotal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NotaFiscals");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.Prestador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prestador");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.Tomador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeRazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroResidencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tomador");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.Usuario.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CFPCNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.Itens", b =>
                {
                    b.HasOne("SharpSystem.Domain.Entities.NFS.Lista", "lista")
                        .WithMany()
                        .HasForeignKey("listaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lista");
                });

            modelBuilder.Entity("SharpSystem.Domain.Entities.NFS.NFSE", b =>
                {
                    b.HasOne("SharpSystem.Domain.Entities.NFS.Itens", "Itens")
                        .WithMany()
                        .HasForeignKey("ItensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharpSystem.Domain.Entities.NFS.NotaFiscal", "NotaFiscal")
                        .WithMany()
                        .HasForeignKey("NotaFiscalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharpSystem.Domain.Entities.NFS.Prestador", "Prestador")
                        .WithMany()
                        .HasForeignKey("PrestadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharpSystem.Domain.Entities.NFS.Tomador", "Tomador")
                        .WithMany()
                        .HasForeignKey("TomadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Itens");

                    b.Navigation("NotaFiscal");

                    b.Navigation("Prestador");

                    b.Navigation("Tomador");
                });
#pragma warning restore 612, 618
        }
    }
}