﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentskiDom.Models;

namespace StudentskiDom.Migrations
{
    [DbContext(typeof(StudentskiDomContext))]
    [Migration("20200526113211_FiftyFifty")]
    partial class FiftyFifty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentskiDom.Models.Blagajna", b =>
                {
                    b.Property<int>("BlagajnaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("StanjeBudgeta")
                        .HasColumnType("float");

                    b.Property<int>("UpravaId")
                        .HasColumnType("int");

                    b.HasKey("BlagajnaId");

                    b.HasIndex("UpravaId")
                        .IsUnique();

                    b.ToTable("Blagajna");
                });

            modelBuilder.Entity("StudentskiDom.Models.DnevniMeni", b =>
                {
                    b.Property<int>("DnevniMeniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DnevniMeniId");

                    b.ToTable("DnevniMeni");
                });

            modelBuilder.Entity("StudentskiDom.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestoranId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId1")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestoranId");

                    b.HasIndex("StudentId1");

                    b.ToTable("Korisnik");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Korisnik");
                });

            modelBuilder.Entity("StudentskiDom.Models.LicniPodaci", b =>
                {
                    b.Property<int>("LicniPodaciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Jmbg")
                        .HasColumnType("bigint");

                    b.Property<string>("MjestoRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobitel")
                        .HasColumnType("int");

                    b.Property<int>("Pol")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicniPodaciId");

                    b.ToTable("LicniPodaci");
                });

            modelBuilder.Entity("StudentskiDom.Models.PrebivalisteInfo", b =>
                {
                    b.Property<int>("PrebivalisteInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kanton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opcina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrebivalisteInfoId");

                    b.ToTable("PrebivalisteInfo");
                });

            modelBuilder.Entity("StudentskiDom.Models.Rucak", b =>
                {
                    b.Property<int>("RucakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RucakId");

                    b.HasIndex("DnevniMeniId");

                    b.ToTable("Rucak");
                });

            modelBuilder.Entity("StudentskiDom.Models.SkolovanjeInfo", b =>
                {
                    b.Property<int>("SkolovanjeInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojIndeksa")
                        .HasColumnType("int");

                    b.Property<int>("CiklusStudija")
                        .HasColumnType("int");

                    b.Property<string>("Fakultet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GodinaStudija")
                        .HasColumnType("int");

                    b.HasKey("SkolovanjeInfoId");

                    b.ToTable("SkolovanjeInfo");
                });

            modelBuilder.Entity("StudentskiDom.Models.Vecera", b =>
                {
                    b.Property<int>("VeceraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VeceraId");

                    b.HasIndex("DnevniMeniId");

                    b.ToTable("Vecera");
                });

            modelBuilder.Entity("StudentskiDom.Models.Restoran", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Korisnik");

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasIndex("DnevniMeniId")
                        .IsUnique()
                        .HasFilter("[DnevniMeniId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Restoran");
                });

            modelBuilder.Entity("StudentskiDom.Models.Student", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Korisnik");

                    b.Property<int>("BrojRucaka")
                        .HasColumnType("int");

                    b.Property<int>("BrojVecera")
                        .HasColumnType("int");

                    b.Property<int>("LicniPodaciId")
                        .HasColumnType("int");

                    b.Property<int>("PrebivalisteInfoId")
                        .HasColumnType("int");

                    b.Property<int>("SkolovanjeInfoId")
                        .HasColumnType("int");

                    b.Property<int>("SobaId")
                        .HasColumnType("int");

                    b.HasIndex("LicniPodaciId")
                        .IsUnique()
                        .HasFilter("[LicniPodaciId] IS NOT NULL");

                    b.HasIndex("PrebivalisteInfoId")
                        .IsUnique()
                        .HasFilter("[PrebivalisteInfoId] IS NOT NULL");

                    b.HasIndex("SkolovanjeInfoId")
                        .IsUnique()
                        .HasFilter("[SkolovanjeInfoId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("StudentskiDom.Models.Uprava", b =>
                {
                    b.HasBaseType("StudentskiDom.Models.Korisnik");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Uprava");
                });

            modelBuilder.Entity("StudentskiDom.Models.Blagajna", b =>
                {
                    b.HasOne("StudentskiDom.Models.Uprava", "Uprava")
                        .WithOne("Blagajna")
                        .HasForeignKey("StudentskiDom.Models.Blagajna", "UpravaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Korisnik", b =>
                {
                    b.HasOne("StudentskiDom.Models.Restoran", "Restoran")
                        .WithMany()
                        .HasForeignKey("RestoranId");

                    b.HasOne("StudentskiDom.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId1");
                });

            modelBuilder.Entity("StudentskiDom.Models.Rucak", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithMany("Rucak")
                        .HasForeignKey("DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Vecera", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithMany("Vecera")
                        .HasForeignKey("DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Restoran", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithOne("Restoran")
                        .HasForeignKey("StudentskiDom.Models.Restoran", "DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentskiDom.Models.Student", b =>
                {
                    b.HasOne("StudentskiDom.Models.LicniPodaci", "LicniPodaci")
                        .WithOne("Student")
                        .HasForeignKey("StudentskiDom.Models.Student", "LicniPodaciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.PrebivalisteInfo", "PrebivalisteInfo")
                        .WithOne("Student")
                        .HasForeignKey("StudentskiDom.Models.Student", "PrebivalisteInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentskiDom.Models.SkolovanjeInfo", "SkolovanjeInfo")
                        .WithOne("Student")
                        .HasForeignKey("StudentskiDom.Models.Student", "SkolovanjeInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
