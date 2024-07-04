﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using front.DataAcess.Data;

#nullable disable

namespace front.DataAcess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240104121505_addProductsToDb")]
    partial class addProductsToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("front.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "人偶"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "扭蛋"
                        });
                });

            modelBuilder.Entity("front.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "毛茸茸的小獅子穿著那套大紅衣裳，戴起了那可愛的毛絨帽，那條翹著的尾巴，像鐘擺一樣。",
                            Name = "獅子座",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "以希臘的維納斯女神為設計靈感整體色調以白色為主，金色、亮黃色突出天秤座的優雅大方。",
                            Name = "天秤座",
                            Price = 1040.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "仙女閣裡，淡淡一抹胭脂，著一身粉嫩花裙，花苞般的裙子，宛如含羞待放的花朵，出尘如仙。",
                            Name = "處女座",
                            Price = 1270.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "夏天開始的第一個星座，以螃蟹可愛的蟹鉗和鮮豔的橙黃色為主為靈感來源，融入古風元素。",
                            Name = "巨蟹座",
                            Price = 790.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "这些兔兔帶給人們放鬆、開心和充滿溫馨感的感覺，營造出一種歡樂和愉悅的氛圍，讓人感受到無憂無慮的野餐時光。",
                            Name = "野餐兔兔",
                            Price = 300.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
