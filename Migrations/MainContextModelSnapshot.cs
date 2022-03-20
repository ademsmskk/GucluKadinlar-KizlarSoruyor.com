﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GucluKadinlar.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Visibility")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "adem@gmail.com",
                            IsBlocked = false,
                            Password = "pass",
                            RoleId = 1,
                            Visibility = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "ali@gmail.com",
                            IsBlocked = false,
                            Password = "pass",
                            RoleId = 2,
                            Visibility = true
                        });
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yazılım"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ekonomi"
                        });
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("LikeCount")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "new Comment",
                            DateTime = new DateTime(2022, 3, 12, 20, 31, 50, 743, DateTimeKind.Local),
                            LikeCount = 2,
                            PostId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "No Comment",
                            DateTime = new DateTime(2022, 3, 12, 20, 31, 50, 743, DateTimeKind.Local).AddTicks(4),
                            LikeCount = 8,
                            PostId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BigPath")
                        .HasColumnType("longtext");

                    b.Property<string>("MiddlePath")
                        .HasColumnType("longtext");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("SmallPath")
                        .HasColumnType("longtext");

                    b.Property<int?>("USerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("USerId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("LikeCount")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TitleId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "Lorem Ipsum is simply dummy text of tccacapclspaplcpacpasclpplacplclpalpcplaclpasclpcslplc",
                            DateTime = new DateTime(2022, 3, 12, 20, 31, 50, 742, DateTimeKind.Local).AddTicks(6455),
                            LikeCount = 5,
                            TitleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "it is a long established fact that a reader will be distracted by the readable content of a page",
                            DateTime = new DateTime(2022, 3, 12, 20, 31, 50, 742, DateTimeKind.Local).AddTicks(6471),
                            LikeCount = 4,
                            TitleId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Standard"
                        });
                });

            modelBuilder.Entity("Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yazılım Nasıl Öğrenilir"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ekonomik Sorunlar"
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            FirstName = "adem",
                            LastName = "Simsek",
                            PhoneNumber = 5451848,
                            Username = "as"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            FirstName = "ali",
                            LastName = "veli",
                            PhoneNumber = 5300000,
                            Username = "av"
                        });
                });

            modelBuilder.Entity("Account", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Comment", b =>
                {
                    b.HasOne("Post", "Post")
                        .WithMany("Comment")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("Comment")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Picture", b =>
                {
                    b.HasOne("Post", "Post")
                        .WithMany("Picture")
                        .HasForeignKey("PostId");

                    b.HasOne("User", "User")
                        .WithMany("Picture")
                        .HasForeignKey("USerId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Post", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithMany("Post")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Title", "Title")
                        .WithMany("Post")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany("Post")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Title");

                    b.Navigation("User");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("Account", "Account")
                        .WithMany("User")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Account", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Post");
                });

            modelBuilder.Entity("Post", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Title", b =>
                {
                    b.Navigation("Post");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Picture");

                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
