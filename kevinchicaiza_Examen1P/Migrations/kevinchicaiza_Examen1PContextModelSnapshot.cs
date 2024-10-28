﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kevinchicaiza_Examen1P.Data;

#nullable disable

namespace kevinchicaiza_Examen1P.Migrations
{
    [DbContext(typeof(kevinchicaiza_Examen1PContext))]
    partial class kevinchicaiza_Examen1PContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kevinchicaiza_Examen1P.Models.KcGymshark", b =>
                {
                    b.Property<int>("KCRopaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KCRopaid"));

                    b.Property<string>("Emaildelusuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KCColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KCDescripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KCFechadeEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KCFechadeSalida")
                        .HasColumnType("datetime2");

                    b.Property<string>("KCGenero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KCName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("KCPrecio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("KCtallas")
                        .HasColumnType("bit");

                    b.Property<string>("KcTipodegenero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KCRopaid");

                    b.ToTable("KcGymshark");
                });
#pragma warning restore 612, 618
        }
    }
}