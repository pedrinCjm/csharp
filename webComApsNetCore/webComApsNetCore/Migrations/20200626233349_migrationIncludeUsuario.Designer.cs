﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webComApsNetCore.Data;

namespace webComApsNetCore.Migrations
{
    [DbContext(typeof(webComApsNetCoreContext))]
    [Migration("20200626233349_migrationIncludeUsuario")]
    partial class migrationIncludeUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("webComApsNetCore.Models.Carro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cor");

                    b.Property<int>("placa");

                    b.HasKey("id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("webComApsNetCore.Models.CategoriaLivro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Generico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("carroid");

                    b.Property<int?>("departmentId");

                    b.HasKey("Id");

                    b.HasIndex("carroid");

                    b.HasIndex("departmentId");

                    b.ToTable("Generico");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Livros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaLivroId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaLivroId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Usuario", b =>
                {
                    b.Property<decimal>("UsuarioId");

                    b.Property<decimal>("CEP");

                    b.Property<decimal>("CNPJ");

                    b.Property<decimal>("CPF");

                    b.Property<string>("NoUsuario");

                    b.Property<decimal>("Telefone");

                    b.Property<DateTime>("UsuDatNasc");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Department", b =>
                {
                    b.HasOne("webComApsNetCore.Models.Empresa")
                        .WithMany("Departamentos")
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Generico", b =>
                {
                    b.HasOne("webComApsNetCore.Models.Carro", "carro")
                        .WithMany()
                        .HasForeignKey("carroid");

                    b.HasOne("webComApsNetCore.Models.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentId");
                });

            modelBuilder.Entity("webComApsNetCore.Models.Livros", b =>
                {
                    b.HasOne("webComApsNetCore.Models.CategoriaLivro")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaLivroId");
                });
#pragma warning restore 612, 618
        }
    }
}
