﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CriptoDB.Migrations
{
    [DbContext(typeof(CryptoContext))]
    partial class CryptoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Cripto.Models.Cartera", b =>
                {
                    b.Property<int>("CarteraId")
                        .HasColumnType("int");

                    b.Property<string>("Exchange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarteraId");

                    b.ToTable("Cartera");
                });

            modelBuilder.Entity("Cripto.Models.Contrato", b =>
                {
                    b.Property<int>("ContratoId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CarteraId")
                        .HasColumnType("int");

                    b.Property<string>("MonedaId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ContratoId");

                    b.HasIndex("CarteraId");

                    b.HasIndex("MonedaId");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("Cripto.Models.Moneda", b =>
                {
                    b.Property<string>("MonedaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Actual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Maximo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MonedaId");

                    b.ToTable("Moneda");
                });

            modelBuilder.Entity("Cripto.Models.Contrato", b =>
                {
                    b.HasOne("Cripto.Models.Cartera", "Cartera")
                        .WithMany("ContratosCartera")
                        .HasForeignKey("CarteraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cripto.Models.Moneda", "Moneda")
                        .WithMany("ContratosMoneda")
                        .HasForeignKey("MonedaId");

                    b.Navigation("Cartera");

                    b.Navigation("Moneda");
                });

            modelBuilder.Entity("Cripto.Models.Cartera", b =>
                {
                    b.Navigation("ContratosCartera");
                });

            modelBuilder.Entity("Cripto.Models.Moneda", b =>
                {
                    b.Navigation("ContratosMoneda");
                });
#pragma warning restore 612, 618
        }
    }
}
