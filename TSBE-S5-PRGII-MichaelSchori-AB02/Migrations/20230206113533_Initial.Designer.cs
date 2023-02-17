﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TSBE_S5_PRGII_MichaelSchori_AB02;

#nullable disable

namespace TSBES5PRGIIMichaelSchoriAB02.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230206113533_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TSBE_S5_PRGII_MichaelSchori_AB02.Kunde", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("LieferkostenID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ortschaft")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("LieferkostenID");

                    b.ToTable("Kunden");
                });

            modelBuilder.Entity("TSBE_S5_PRGII_MichaelSchori_AB02.Lieferkosten", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("NameZone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Preis")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Lieferkosten");
                });

            modelBuilder.Entity("TSBE_S5_PRGII_MichaelSchori_AB02.Kunde", b =>
                {
                    b.HasOne("TSBE_S5_PRGII_MichaelSchori_AB02.Lieferkosten", "Lieferkosten")
                        .WithMany("Kunden")
                        .HasForeignKey("LieferkostenID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Lieferkosten");
                });

            modelBuilder.Entity("TSBE_S5_PRGII_MichaelSchori_AB02.Lieferkosten", b =>
                {
                    b.Navigation("Kunden");
                });
#pragma warning restore 612, 618
        }
    }
}