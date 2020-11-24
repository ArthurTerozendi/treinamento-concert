﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VeiculosAPI2.Entities;

namespace VeiculosAPI2.Migrations
{
    [DbContext(typeof(VeiculosContext))]
    [Migration("20201124222239_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("VeiculosAPI2.Entities.Caminhao", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("cor")
                        .HasColumnType("text");

                    b.Property<string>("marca")
                        .HasColumnType("text");

                    b.Property<string>("modelo")
                        .HasColumnType("text");

                    b.Property<int>("numeroEixos")
                        .HasColumnType("integer");

                    b.Property<string>("placa")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Caminhao");
                });

            modelBuilder.Entity("VeiculosAPI2.Entities.Carro", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("cor")
                        .HasColumnType("text");

                    b.Property<string>("marca")
                        .HasColumnType("text");

                    b.Property<string>("modelo")
                        .HasColumnType("text");

                    b.Property<string>("placa")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("VeiculosAPI2.Entities.Moto", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("cor")
                        .HasColumnType("text");

                    b.Property<string>("marca")
                        .HasColumnType("text");

                    b.Property<string>("modelo")
                        .HasColumnType("text");

                    b.Property<string>("placa")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Moto");
                });
#pragma warning restore 612, 618
        }
    }
}
