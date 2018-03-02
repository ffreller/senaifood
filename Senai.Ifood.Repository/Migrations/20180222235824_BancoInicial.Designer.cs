﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Senai.Ifood.Repository.Context;
using System;

namespace Senai.Ifood.Repository.Migrations
{
    [DbContext(typeof(IFoodContext))]
    [Migration("20180222235824_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.ClienteDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.EspecialidadeDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.PermissaoDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Permissoes");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.ProdutoDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("RestauranteId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.RestauranteDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("EspecialidadesId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadesId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.UsuarioDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.UsuarioPermissaoDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("PermissaoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("PermissaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuariosPermissoes");
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.ClienteDomain", b =>
                {
                    b.HasOne("Senai.Ifood.Domain.Entities.UsuarioDomain", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.ProdutoDomain", b =>
                {
                    b.HasOne("Senai.Ifood.Domain.Entities.RestauranteDomain", "Restaurante")
                        .WithMany("Produtos")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.RestauranteDomain", b =>
                {
                    b.HasOne("Senai.Ifood.Domain.Entities.EspecialidadeDomain", "Especialidades")
                        .WithMany("Restaurantes")
                        .HasForeignKey("EspecialidadesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Senai.Ifood.Domain.Entities.UsuarioDomain", "Usuario")
                        .WithMany("Restaurantes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Senai.Ifood.Domain.Entities.UsuarioPermissaoDomain", b =>
                {
                    b.HasOne("Senai.Ifood.Domain.Entities.PermissaoDomain", "Permissao")
                        .WithMany("UsuariosPermissoes")
                        .HasForeignKey("PermissaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Senai.Ifood.Domain.Entities.UsuarioDomain", "Usuario")
                        .WithMany("UsuariosPermissoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
