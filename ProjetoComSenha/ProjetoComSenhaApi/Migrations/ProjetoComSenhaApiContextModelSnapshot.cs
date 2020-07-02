﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoComSenhaApi.Data;

namespace ProjetoComSenhaApi.Migrations
{
    [DbContext(typeof(ProjetoComSenhaApiContext))]
    partial class ProjetoComSenhaApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoComSenhaApi.Models.HistoricoPartida", b =>
                {
                    b.Property<int>("HistoricoPartidaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JogadorId");

                    b.HasKey("HistoricoPartidaId");

                    b.HasIndex("JogadorId")
                        .IsUnique();

                    b.ToTable("HistoricoPartida");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Jogador", b =>
                {
                    b.Property<int>("JogadorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NickJogador");

                    b.Property<string>("NoJogador");

                    b.Property<int?>("PartidaId");

                    b.HasKey("JogadorId");

                    b.HasIndex("PartidaId");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Jogo", b =>
                {
                    b.Property<int>("JogoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DsJogo");

                    b.Property<string>("NoJogo");

                    b.Property<int>("TipoJogoId");

                    b.HasKey("JogoId");

                    b.HasIndex("TipoJogoId");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Partida", b =>
                {
                    b.Property<int>("PartidaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("HistoricoPartidaId");

                    b.Property<int>("JogoId");

                    b.Property<string>("ObsPartida");

                    b.Property<string>("VencedorJogo");

                    b.HasKey("PartidaId");

                    b.HasIndex("HistoricoPartidaId");

                    b.HasIndex("JogoId");

                    b.ToTable("Partida");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Regiao", b =>
                {
                    b.Property<int>("RegiaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("RegiaoId");

                    b.ToTable("Regiao");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.TipoJogo", b =>
                {
                    b.Property<int>("TipoJogoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DsTipoJogo");

                    b.Property<string>("NoTipoJogo");

                    b.Property<int>("QtdMaxJogadores");

                    b.HasKey("TipoJogoId");

                    b.ToTable("TipoJogo");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.HistoricoPartida", b =>
                {
                    b.HasOne("ProjetoComSenhaApi.Models.Jogador", "Jogador")
                        .WithOne("HistoricoPartidas")
                        .HasForeignKey("ProjetoComSenhaApi.Models.HistoricoPartida", "JogadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Jogador", b =>
                {
                    b.HasOne("ProjetoComSenhaApi.Models.Partida")
                        .WithMany("Jogadores")
                        .HasForeignKey("PartidaId");
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Jogo", b =>
                {
                    b.HasOne("ProjetoComSenhaApi.Models.TipoJogo", "TipoJogo")
                        .WithMany("Jogos")
                        .HasForeignKey("TipoJogoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoComSenhaApi.Models.Partida", b =>
                {
                    b.HasOne("ProjetoComSenhaApi.Models.HistoricoPartida")
                        .WithMany("Partidas")
                        .HasForeignKey("HistoricoPartidaId");

                    b.HasOne("ProjetoComSenhaApi.Models.Jogo", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}