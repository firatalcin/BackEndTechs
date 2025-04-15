﻿// <auto-generated />
using DotnetStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("DotnetStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Elektronik",
                            Url = "elektronik"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Beyaz Eşya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Giyim",
                            Url = "giyim"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kozmetik",
                            Url = "kozmetik"
                        });
                });

            modelBuilder.Entity("DotnetStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MainPage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "1.jpeg",
                            IsActive = false,
                            MainPage = true,
                            Name = "Apple Watch 7",
                            Price = 10000.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "2.jpeg",
                            IsActive = true,
                            MainPage = true,
                            Name = "Apple Watch 8",
                            Price = 20000.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "3.jpeg",
                            IsActive = true,
                            MainPage = true,
                            Name = "Apple Watch 9",
                            Price = 30000.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "4.jpeg",
                            IsActive = false,
                            MainPage = false,
                            Name = "Apple Watch 10",
                            Price = 40000.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "5.jpeg",
                            IsActive = true,
                            MainPage = true,
                            Name = "Apple Watch 11",
                            Price = 50000.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "6.jpeg",
                            IsActive = false,
                            MainPage = false,
                            Name = "Apple Watch 12",
                            Price = 60000.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "7.jpeg",
                            IsActive = false,
                            MainPage = false,
                            Name = "Apple Watch 14",
                            Price = 70000.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?",
                            Image = "8.jpeg",
                            IsActive = true,
                            MainPage = true,
                            Name = "Apple Watch 15",
                            Price = 80000.0
                        });
                });

            modelBuilder.Entity("DotnetStore.Models.Product", b =>
                {
                    b.HasOne("DotnetStore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DotnetStore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
