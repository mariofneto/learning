﻿// <auto-generated />
using System;
using FlashCards.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlashCards.Migrations
{
    [DbContext(typeof(FlashCardDbContext))]
    partial class FlashCardDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlashCards.Models.FlashCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FlashCardId")
                        .HasColumnType("int");

                    b.Property<string>("TextBack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextFront")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlashCardId");

                    b.ToTable("FlashCards");
                });

            modelBuilder.Entity("FlashCards.Models.FlashCard", b =>
                {
                    b.HasOne("FlashCards.Models.FlashCard", null)
                        .WithMany("Cards")
                        .HasForeignKey("FlashCardId");
                });

            modelBuilder.Entity("FlashCards.Models.FlashCard", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}