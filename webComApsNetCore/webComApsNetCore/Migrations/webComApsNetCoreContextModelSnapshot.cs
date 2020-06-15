﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webComApsNetCore.Data;

namespace webComApsNetCore.Migrations
{
    [DbContext(typeof(webComApsNetCoreContext))]
    partial class webComApsNetCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("webComApsNetCore.Models.Department", b =>
                {
                    b.HasOne("webComApsNetCore.Models.Empresa")
                        .WithMany("Departamentos")
                        .HasForeignKey("EmpresaId");
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
