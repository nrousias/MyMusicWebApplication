﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMusicWebApplication.Models;

namespace MyMusicWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191202152428_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electronica"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Jazz"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Rock"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Soul-Funk-Disco"
                        });
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.MusicAlbum", b =>
                {
                    b.Property<int>("MusicAlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMusicAlbumOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MusicAlbumId");

                    b.HasIndex("CategoryId");

                    b.ToTable("MusicAlbums");

                    b.HasData(
                        new
                        {
                            MusicAlbumId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://p2c.xplace.de/mediastreaming/309e1b7704f3fd8f44a42b3dafda5fce24ee1e584a149bf00c4894ecce1b502593715f587dc65e66c7ee8eaf2be51018?skey=-get-ws-",
                            ImageUrl = "https://p2c.xplace.de/mediastreaming/309e1b7704f3fd8f44a42b3dafda5fce24ee1e584a149bf00c4894ecce1b502593715f587dc65e66c7ee8eaf2be51018?skey=-get-ws-",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = true,
                            LongDescription = "Random Access Memories is the fourth studio album by French electronic music duo Daft Punk, released on 17 May 2013 by Daft Life and Columbia Records.",
                            Name = "Random Access Memories",
                            Price = 9.9900000000000002,
                            ShortDescription = "Studio album by Daft Punk"
                        },
                        new
                        {
                            MusicAlbumId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/91968jEoKIL._SL1500_.jpg",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91968jEoKIL._SL1500_.jpg",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = true,
                            LongDescription = "A Love Supreme is an album by American jazz saxophonist John Coltrane. He recorded it in one session on December 9, 1964, at Van Gelder Studio in Englewood Cliffs, New Jersey, leading a quartet featuring pianist McCoy Tyner, bassist Jimmy Garrison, and drummer Elvin Jones.",
                            Name = "A Love Supreme",
                            Price = 13.970000000000001,
                            ShortDescription = "Album by John Coltrane"
                        },
                        new
                        {
                            MusicAlbumId = 3,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://p2c.xplace.de/mediastreaming/c809b218646da5fc5bebc8e2e82205788548ed82b7c7d26bcf5e989f9d13db6da7e4f1aa571fac8fc7ee8eaf2be51018?skey=-get-ws-",
                            ImageUrl = "https://p2c.xplace.de/mediastreaming/c809b218646da5fc5bebc8e2e82205788548ed82b7c7d26bcf5e989f9d13db6da7e4f1aa571fac8fc7ee8eaf2be51018?skey=-get-ws-",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = false,
                            LongDescription = "The Dark Side of the Moon is the eighth studio album by English rock band Pink Floyd, released on 1 March 1973 by Harvest Records.",
                            Name = "Dark Side Of The Moon",
                            Price = 29.989999999999998,
                            ShortDescription = "Studio album by Pink Floyd"
                        },
                        new
                        {
                            MusicAlbumId = 4,
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://p2c.xplace.de/mediastreaming/97dfccd0e349eef43bb50291f81baf34a657d337e7b585e63547c8df537b15e2fa11b666724a8cfcc7ee8eaf2be51018?skey=-get-ws-",
                            ImageUrl = "https://p2c.xplace.de/mediastreaming/97dfccd0e349eef43bb50291f81baf34a657d337e7b585e63547c8df537b15e2fa11b666724a8cfcc7ee8eaf2be51018?skey=-get-ws-",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = false,
                            LongDescription = "What's Going On is the eleventh studio album by American soul singer, songwriter, and producer Marvin Gaye. It was released on May 21, 1971, by the Motown Records-subsidiary label Tamla.",
                            Name = "What's Going On",
                            Price = 6.9900000000000002,
                            ShortDescription = "Studio album by Marvin Gaye"
                        },
                        new
                        {
                            MusicAlbumId = 5,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://d2s36jztkuk7aw.cloudfront.net/sites/default/files/styles/media_responsive_widest/public/tile/image/original_441.jpg?itok=bSu8Jojn&timestamp=1354886431",
                            ImageUrl = "https://d2s36jztkuk7aw.cloudfront.net/sites/default/files/styles/media_responsive_widest/public/tile/image/original_441.jpg?itok=bSu8Jojn&timestamp=1354886431",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = true,
                            LongDescription = "Abbey Road is the eleventh studio album by English rock band the Beatles, released on 26 September 1969 by Apple Records. The recording sessions were the last in which all four Beatles participated.",
                            Name = "Abbey Road (Ltd. 50th Ann. Del.Ed.)",
                            Price = 26.989999999999998,
                            ShortDescription = "Album by The Beatles"
                        },
                        new
                        {
                            MusicAlbumId = 6,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/Bohemian_Rhapsody_soundtrack.jpg/220px-Bohemian_Rhapsody_soundtrack.jpg",
                            ImageUrl = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwiD18_XlYjmAhUAwAIHHYRYBp8QjRx6BAgBEAQ&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FBohemian_Rhapsody%3A_The_Original_Soundtrack&psig=AOvVaw20C8n--N6lwZvimmGb1EdN&ust=1574867748716840",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = false,
                            LongDescription = "Bohemian Rhapsody: The Original Soundtrack is the soundtrack album to the 2018 biographical film of the same name. The soundtrack features several Queen songs and unreleased recordings including several tracks from the group's performance at Live Aid in 1985.",
                            Name = "Bohemian Rhapsody",
                            Price = 15.98,
                            ShortDescription = "Soundtrack album by Queen"
                        },
                        new
                        {
                            MusicAlbumId = 7,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://img.discogs.com/s3yi8HkyqdGoOKEsp4-6G-M9sO8=/fit-in/574x567/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-652096-1243886836.jpeg.jpg",
                            ImageUrl = "https://img.discogs.com/s3yi8HkyqdGoOKEsp4-6G-M9sO8=/fit-in/574x567/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-652096-1243886836.jpeg.jpg",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = false,
                            LongDescription = "Collected is a compilation album by British trip hop collective Massive Attack, released on 27 March 2006. The album was preceded by the release of the single 'Live with Me' on 13 March. It collects most of the band's singles up until this point.",
                            Name = "Collected",
                            Price = 6.9900000000000002,
                            ShortDescription = "Compilation album by Massive Attack"
                        },
                        new
                        {
                            MusicAlbumId = 8,
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/416CVJPhy%2BL._SY355_.jpg",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/416CVJPhy%2BL._SY355_.jpg",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = false,
                            LongDescription = "Love Songs is a 2003 album by Barry White.",
                            Name = "Love Songs",
                            Price = 9.9900000000000002,
                            ShortDescription = "Barry White album"
                        },
                        new
                        {
                            MusicAlbumId = 9,
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://www.bear-family.com/media/image/g0/80/d3/602498325841.jpg",
                            ImageUrl = "https://www.bear-family.com/media/image/g0/80/d3/602498325841.jpg",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = false,
                            LongDescription = "40 tracks, recorded 1957-85, 16-page booklet incl. his biography and many pictures. ",
                            Name = "Gold",
                            Price = 11.99,
                            ShortDescription = "Album by James Brown"
                        },
                        new
                        {
                            MusicAlbumId = 10,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/51ggUsokV3L.jpg",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51ggUsokV3L.jpg",
                            InStock = true,
                            IsMusicAlbumOfTheWeek = true,
                            LongDescription = "Kind of Blue is a studio album by American jazz trumpeter Miles Davis. It was recorded on March 2 and April 22, 1959, at Columbia's 30th Street Studio in New York City, and released on August 17 of that year by Columbia Records.",
                            Name = "Kind Of Blue",
                            Price = 6.9900000000000002,
                            ShortDescription = "Studio album by Miles Davis"
                        });
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MusicAlbumId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("MusicAlbumId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MusicAlbumId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("MusicAlbumId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.MusicAlbum", b =>
                {
                    b.HasOne("MyMusicWebApplication.Models.Category", "Category")
                        .WithMany("MusicAlbums")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.OrderDetail", b =>
                {
                    b.HasOne("MyMusicWebApplication.Models.MusicAlbum", "MusicAlbum")
                        .WithMany()
                        .HasForeignKey("MusicAlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMusicWebApplication.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMusicWebApplication.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("MyMusicWebApplication.Models.MusicAlbum", "MusicAlbum")
                        .WithMany()
                        .HasForeignKey("MusicAlbumId");
                });
#pragma warning restore 612, 618
        }
    }
}
