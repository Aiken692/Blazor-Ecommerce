﻿// <auto-generated />
using System;
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("18177dd9-3e05-4f08-b567-8b8921478c04"),
                            Description = "The Hitchhiker's Guide to the Galaxy adalah buku pertama dari lima seri trilogi komedi fiksi ilmiah Hitchhiker's Guide to the Galaxy karya Douglas Adams (buku keenam ditulis oleh Eoin Colfer). Novel ini merupakan adaptasi dari empat bagian pertama seri radio dengan nama yang sama. Novel ini pertama diterbitkan di London tanggal 12 Oktober 1979.[2] Buku ini terjual 250.000 eksemplar dalam kurun tiga bulan setelah diluncurkan.[3]Judul novel ini diambil dari The Hitchhiker's Guide to the Galaxy,",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/id/b/bd/H2G2_UK_front_cover.jpg?20130311090701",
                            Price = 9.9900000000000002,
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = new Guid("4841d2af-c405-480b-8986-609d8a2980c4"),
                            Description = "Ready Player One is a 2018 American science fiction film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                            Price = 7.9900000000000002,
                            Title = "Ready Player One"
                        },
                        new
                        {
                            Id = new Guid("cb8ba409-8bd9-4d09-8981-49001746d5a7"),
                            Description = "Gods and Generals is a novel which serves as a prequel to Michael Shaara's 1974 Pulitzer Prize–winning work about the Battle of Gettysburg, The Killer Angels. Written by Jeffrey Shaara after his father Michael's death in 1988, the novel relates events from 1858 through 1863, during the American Civil War, ending just as the two armies march toward Gettysburg. Shaara also wrote The Last Full Measure, published in 2000, which follows the events presented in The Killer Angels.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/65/GandGbook.jpg",
                            Price = 8.9900000000000002,
                            Title = "Gods and Generals "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
