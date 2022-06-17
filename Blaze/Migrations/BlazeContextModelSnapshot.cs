﻿// <auto-generated />
using System;
using Blaze.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blaze.Migrations
{
    [DbContext(typeof(BlazeContext))]
    partial class BlazeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blaze.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Description = "Eat more Healthy Fruit Pies for your Healthy",
                            Name = "Fruit Pies"
                        },
                        new
                        {
                            CategoryID = 2,
                            Description = "Eat more Healthy Fruit Pies for your Healthy",
                            Name = "Slab Pies"
                        },
                        new
                        {
                            CategoryID = 3,
                            Description = "Eat more Healthy Fruit Pies for your Healthy",
                            Name = "Pumpkin Pies"
                        },
                        new
                        {
                            CategoryID = 4,
                            Description = "Eat more Healthy Fruit Pies for your Healthy",
                            Name = "Bite-Sized Pies"
                        },
                        new
                        {
                            CategoryID = 5,
                            Description = "Eat more Healthy Chocolate Pies for your Healthy",
                            Name = "Chocolate Pies"
                        },
                        new
                        {
                            CategoryID = 6,
                            Description = "Eat more Nutty Fruit Pies for your Healthy",
                            Name = "Nutty Pies"
                        },
                        new
                        {
                            CategoryID = 7,
                            Description = "Eat more Nutty Fruit Pies for your Healthy",
                            Name = "Pie Crust Pies"
                        });
                });

            modelBuilder.Entity("Blaze.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Blaze.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Imgurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbNail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 1,
                            Imgurl = "https://i.pinimg.com/564x/70/19/40/701940ff8f32af9f5f6d4787fbafb0c5.jpg",
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tellus ex, consequat semper quam vel, imperdiet eleifend enim. Nam at efficitur nisi. Suspendisse egestas nulla orci, sed luctus ante scelerisque in. Mauris blandit ligula ac massa sagittis, eget facilisis sapien maximus. Curabitur mauris nisl, gravida eu pretium et, scelerisque nec ex. Fusce et faucibus nisi. Integer egestas arcu eleifend, euismod velit eget, mattis orci. Phasellus rhoncus, ligula et iaculis tempus, odio enim tempus odio, quis malesuada lectus mauris et lacus. Duis justo est, dignissim ac scelerisque vel, congue vitae nisi.",
                            Name = "Easy Blueberry",
                            Price = 23.8m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://i.pinimg.com/564x/70/19/40/701940ff8f32af9f5f6d4787fbafb0c5.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 6,
                            Imgurl = "https://i.pinimg.com/564x/03/76/e0/0376e0f624326e4aaebc4092039c2230.jpg",
                            LongDescription = "Morbi accumsan, ipsum non laoreet molestie, sem ligula suscipit nunc, sit amet vestibulum est enim eu elit. Nam quis ligula nisi. Vestibulum imperdiet rhoncus sapien et viverra. Maecenas tempor, diam a porta laoreet, dolor eros pulvinar justo, ac sodales tortor leo a metus. Aenean lectus neque, mollis malesuada mattis nec, cursus at quam. Curabitur vulputate porttitor tincidunt. Cras pellentesque non velit quis pharetra.",
                            Name = "Classic Blueberry Pie",
                            Price = 25.78m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://i.pinimg.com/564x/03/76/e0/0376e0f624326e4aaebc4092039c2230.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 7,
                            Imgurl = "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Key Lime Pie",
                            Price = 77.7m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 7,
                            Imgurl = "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Cherry Pie",
                            Price = 20.44m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 5,
                            CategoryID = 3,
                            Imgurl = "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Lemon Meringue Pie",
                            Price = 34.55m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 6,
                            CategoryID = 1,
                            Imgurl = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "French Silk Pie",
                            Price = 56.55m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 7,
                            CategoryID = 4,
                            Imgurl = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Apple Crisp",
                            Price = 35.44m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 8,
                            CategoryID = 7,
                            Imgurl = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Rhubarb Pie",
                            Price = 56.4m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 9,
                            CategoryID = 2,
                            Imgurl = "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Sweet Potato Pie",
                            Price = 44.5m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 10,
                            CategoryID = 3,
                            Imgurl = "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Banoffee",
                            Price = 67.87m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 11,
                            CategoryID = 6,
                            Imgurl = "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Coconut Cream Pie",
                            Price = 56.78m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 12,
                            CategoryID = 1,
                            Imgurl = "https://i.pinimg.com/564x/92/68/ad/9268ada511b93b0895d21984a675284b.jpg",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Perfect Blueberry Pie",
                            Price = 34.2m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://i.pinimg.com/564x/92/68/ad/9268ada511b93b0895d21984a675284b.jpg"
                        },
                        new
                        {
                            Id = 13,
                            CategoryID = 7,
                            Imgurl = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Sliced Carrot Pie",
                            Price = 56.4m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/709835/pexels-photo-709835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        },
                        new
                        {
                            Id = 14,
                            CategoryID = 6,
                            Imgurl = "https://images.pexels.com/photos/1634062/pexels-photo-1634062.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Sweet Potato Pie type 4",
                            Price = 44.5m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/1634062/pexels-photo-1634062.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        },
                        new
                        {
                            Id = 15,
                            CategoryID = 4,
                            Imgurl = "https://images.pexels.com/photos/905835/pexels-photo-905835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Banoffee type 2",
                            Price = 87.87m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/905835/pexels-photo-905835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        },
                        new
                        {
                            Id = 16,
                            CategoryID = 1,
                            Imgurl = "https://images.pexels.com/photos/1639567/pexels-photo-1639567.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Sweet Potato Pie",
                            Price = 56.78m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/1639567/pexels-photo-1639567.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        },
                        new
                        {
                            Id = 17,
                            CategoryID = 3,
                            Imgurl = "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Mississippi Mud Pie",
                            Price = 34.2m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671"
                        },
                        new
                        {
                            Id = 18,
                            CategoryID = 2,
                            Imgurl = "https://images.pexels.com/photos/6277/food-sweet-christmas-xmas.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = " Baked Banoffee type ",
                            Price = 97.87m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/6277/food-sweet-christmas-xmas.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        },
                        new
                        {
                            Id = 19,
                            CategoryID = 2,
                            Imgurl = "https://images.pexels.com/photos/1346217/pexels-photo-1346217.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Egg White Baked",
                            Price = 76.78m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/1346217/pexels-photo-1346217.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        },
                        new
                        {
                            Id = 20,
                            CategoryID = 2,
                            Imgurl = "https://images.pexels.com/photos/2928378/pexels-photo-2928378.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                            Name = "Lemon Meringue Pie type 2",
                            Price = 89.20m,
                            ShortDescription = "Lorem ipsum dollor",
                            ThumbNail = "https://images.pexels.com/photos/2928378/pexels-photo-2928378.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500"
                        });
                });

            modelBuilder.Entity("Blaze.Model.Product", b =>
                {
                    b.HasOne("Blaze.Model.Category", "Category")
                        .WithMany("products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Blaze.Model.Category", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
