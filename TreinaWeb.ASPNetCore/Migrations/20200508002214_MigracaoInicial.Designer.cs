﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TreinaWeb.ASPNetCore.Context;

namespace TreinaWeb.ASPNetCore.Migrations
{
    [DbContext(typeof(TreinaWebASPNetCoreDbContext))]
    [Migration("20200508002214_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TreinaWeb.ASPNetCore.Models.Pessoa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Idade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
