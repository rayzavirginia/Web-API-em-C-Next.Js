﻿// <auto-generated />
using Destinos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Destinos.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240112191800_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Destinos.Model.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino_estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino_nome");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino_pais");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino_valor");

                    b.Property<string>("destinoUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino_url");

                    b.HasKey("Id");

                    b.ToTable("destinos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = "Ceará",
                            Nome = "Jericoacoara",
                            Pais = "Brasil",
                            Valor = "R$ 659,00",
                            destinoUrl = "https://images.app.goo.gl/ABgHR8ke9GDL989LA"
                        },
                        new
                        {
                            Id = 2,
                            Estado = "-----",
                            Nome = "Cancún",
                            Pais = "México",
                            Valor = "R$ 2.000,00",
                            destinoUrl = "https://images.app.goo.gl/ivU6g68fYRVsVg4j8"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
