﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using forFluentApi;

#nullable disable

namespace forFluentApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("forFluentApi.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("mashinaning nomi ");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matiz"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Spark"
                        });
                });

            modelBuilder.Entity("forFluentApi.Models.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Uyning manzili ");

                    b.HasKey("Id");

                    b.ToTable("Homes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Andijon viloyati Xo'jaobod tumani"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Andijon viloyati Buloqboshi tumani"
                        });
                });

            modelBuilder.Entity("forFluentApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Foydalanuvchining ismi ");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Foydalanuvchining familiyasi ");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Firdavsbek",
                            LastName = "Turdiyev"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Quvvatbek",
                            LastName = "Turdiyev"
                        });
                });

            modelBuilder.Entity("forFluentApi.Models.UserCar", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("CarId", "UserId");

                    b.ToTable("UserCars");
                });

            modelBuilder.Entity("forFluentApi.Models.UserHome", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("HomeId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("UserId", "HomeId");

                    b.HasIndex("HomeId");

                    b.ToTable("UserHomes");
                });

            modelBuilder.Entity("forFluentApi.Models.UserCar", b =>
                {
                    b.HasOne("forFluentApi.Models.Car", "cars")
                        .WithMany("UserCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("forFluentApi.Models.User", "users")
                        .WithMany("UserCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cars");

                    b.Navigation("users");
                });

            modelBuilder.Entity("forFluentApi.Models.UserHome", b =>
                {
                    b.HasOne("forFluentApi.Models.Home", "homes")
                        .WithMany("UserHomes")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("forFluentApi.Models.User", "users")
                        .WithMany("UserHomes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("homes");

                    b.Navigation("users");
                });

            modelBuilder.Entity("forFluentApi.Models.Car", b =>
                {
                    b.Navigation("UserCars");
                });

            modelBuilder.Entity("forFluentApi.Models.Home", b =>
                {
                    b.Navigation("UserHomes");
                });

            modelBuilder.Entity("forFluentApi.Models.User", b =>
                {
                    b.Navigation("UserCars");

                    b.Navigation("UserHomes");
                });
#pragma warning restore 612, 618
        }
    }
}
