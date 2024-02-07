﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppMVCProjectRainbow.Data;

#nullable disable

namespace WebAppMVCProjectRainbow.Migrations.SubjectDb
{
    [DbContext(typeof(SubjectDbContext))]
    partial class SubjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAppMVCProjectRainbow.Models.Subject", b =>
                {
                    b.Property<int>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubId"), 1L, 1);

                    b.Property<int>("SubAuthor")
                        .HasColumnType("int");

                    b.Property<string>("SubName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTeacher")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubId");

                    b.ToTable("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}
