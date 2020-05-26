﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentskiDom.Models;

namespace StudentskiDom.Migrations
{
    [DbContext(typeof(StudentskiDomContext))]
    [Migration("20200526003807_Bismillah")]
    partial class Bismillah
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentskiDom.Models.DnevniMeni", b =>
                {
                    b.Property<int>("DnevniMeniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DnevniMeniId");

                    b.ToTable("DnevniMeni");
                });

            modelBuilder.Entity("StudentskiDom.Models.Jelo", b =>
                {
                    b.Property<int>("JeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DnevniMeniId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JeloId");

                    b.HasIndex("DnevniMeniId");

                    b.ToTable("Jelo");
                });

            modelBuilder.Entity("StudentskiDom.Models.Jelo", b =>
                {
                    b.HasOne("StudentskiDom.Models.DnevniMeni", "DnevniMeni")
                        .WithMany("Rucak")
                        .HasForeignKey("DnevniMeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
