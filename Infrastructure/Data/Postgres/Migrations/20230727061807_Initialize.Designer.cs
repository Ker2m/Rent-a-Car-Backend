﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20230727061807_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("arac_adi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("arac_kilometre")
                        .HasColumnType("integer");

                    b.Property<int>("arac_koltuk")
                        .HasColumnType("integer");

                    b.Property<string>("arac_popularite")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("arac_resmi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("arac_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<string>("vites_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("yakit_tipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Car_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("comment_title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("star_point")
                        .HasColumnType("integer");

                    b.Property<int>("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Car_id");

                    b.HasIndex("user_id");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Reservations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Car_dropoff_location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Car_id")
                        .HasColumnType("integer");

                    b.Property<string>("Car_pickup_location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Choose_A_Date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Pick_Up_Date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("User_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Car_id");

                    b.HasIndex("User_id");

                    b.ToTable("Reservations", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("tc_no")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.HasIndex("phone")
                        .IsUnique();

                    b.HasIndex("tc_no")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Comment", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Cars", "Cars")
                        .WithMany("Comments")
                        .HasForeignKey("Car_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cars");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Reservations", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Cars", "Cars")
                        .WithMany("Reservations")
                        .HasForeignKey("Car_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cars");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Cars", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
