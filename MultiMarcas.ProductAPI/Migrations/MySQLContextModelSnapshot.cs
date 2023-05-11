﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiMarcas.ProductAPI.Model.Context;

namespace MultiMarcas.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MultiMarcas.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("marca");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "bone",
                            Description = "Lindo bone",
                            ImageURL = "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem4.png",
                            Marca = "Lacoste",
                            Name = "Bone",
                            Price = 80m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-shirt",
                            Description = "Linda camiseta",
                            ImageURL = "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem6.png",
                            Marca = "Osklen",
                            Name = "Camiseta",
                            Price = 80m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Polo",
                            Description = "Linda camisa polo",
                            ImageURL = "https://github.com/zolthan31/MultiMarcasII/blob/master/front/MultiMarcas-App/src/assets/imagem7.png",
                            Marca = "Lacoste",
                            Name = "Camisa polo",
                            Price = 120m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
