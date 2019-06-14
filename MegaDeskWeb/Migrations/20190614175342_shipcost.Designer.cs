﻿// <auto-generated />
using System;
using MegaDeskWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWeb.Migrations
{
    [DbContext(typeof(MegaDeskWebContext))]
    [Migration("20190614175342_shipcost")]
    partial class shipcost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskWeb.Models.Desk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Depth");

                    b.Property<int?>("MaterialID");

                    b.Property<int>("NumberOfDrawer");

                    b.Property<int>("Width");

                    b.HasKey("ID");

                    b.HasIndex("MaterialID");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("DeskID");

                    b.Property<float>("Price");

                    b.Property<int?>("ShippingID");

                    b.HasKey("ID");

                    b.HasIndex("DeskID");

                    b.HasIndex("ShippingID");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Desktop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cost");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Desktop");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Shipping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CostLarge");

                    b.Property<float>("CostMed");

                    b.Property<float>("CostSmall");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Desk", b =>
                {
                    b.HasOne("MegaDeskWeb.Models.Desktop", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialID");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.DeskQuote", b =>
                {
                    b.HasOne("MegaDeskWeb.Models.Desk", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskID");

                    b.HasOne("MegaDeskWeb.Models.Shipping", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingID");
                });
#pragma warning restore 612, 618
        }
    }
}
