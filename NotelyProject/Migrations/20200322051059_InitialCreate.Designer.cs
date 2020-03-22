﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotelyProject.Database;

namespace NotelyProject.Migrations
{
    [DbContext(typeof(NotelyDBContext))]
    [Migration("20200322051059_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("NotelyProject.Models.Note", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("detail")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("lastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("subject")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
