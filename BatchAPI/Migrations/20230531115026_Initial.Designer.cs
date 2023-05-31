﻿// <auto-generated />
using System;
using BatchAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BatchAPI.Migrations
{
    [DbContext(typeof(BatchContext))]
    [Migration("20230531115026_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BatchAPI.Entities.Batch", b =>
                {
                    b.Property<int>("UId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UId"), 1L, 1);

                    b.Property<string>("BatchId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilesId")
                        .HasColumnType("int");

                    b.Property<string>("KeyAttribute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadGroups")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueAttribute")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UId");

                    b.HasIndex("FilesId");

                    b.ToTable("BatchDetails");
                });

            modelBuilder.Entity("BatchAPI.Entities.Files", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Filedata")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("files");
                });

            modelBuilder.Entity("BatchAPI.Entities.Batch", b =>
                {
                    b.HasOne("BatchAPI.Entities.Files", "Files")
                        .WithMany()
                        .HasForeignKey("FilesId");

                    b.Navigation("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
