﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(CVContext))]
    partial class CVContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.ContactDetails", b =>
                {
                    b.Property<int>("ContactsDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactsDetailsId");

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("DAL.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactsDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("skills")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactsDetailsId")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DAL.WorkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactDetailsContactsDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("from")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("to")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContactDetailsContactsDetailsId");

                    b.ToTable("WorkExperiences");
                });

            modelBuilder.Entity("DAL.Skills", b =>
                {
                    b.HasOne("DAL.ContactDetails", "ContactDetails")
                        .WithOne("skills")
                        .HasForeignKey("DAL.Skills", "ContactsDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.WorkExperience", b =>
                {
                    b.HasOne("DAL.ContactDetails", null)
                        .WithMany("workExperience")
                        .HasForeignKey("ContactDetailsContactsDetailsId");
                });
#pragma warning restore 612, 618
        }
    }
}
