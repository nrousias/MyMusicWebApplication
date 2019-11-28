using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusicWebApplication.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<double>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicAlbums",
                columns: table => new
                {
                    MusicAlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsMusicAlbumOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicAlbums", x => x.MusicAlbumId);
                    table.ForeignKey(
                        name: "FK_MusicAlbums_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    MusicAlbumId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_MusicAlbums_MusicAlbumId",
                        column: x => x.MusicAlbumId,
                        principalTable: "MusicAlbums",
                        principalColumn: "MusicAlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicAlbumId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_MusicAlbums_MusicAlbumId",
                        column: x => x.MusicAlbumId,
                        principalTable: "MusicAlbums",
                        principalColumn: "MusicAlbumId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Electronica", null },
                    { 2, "Jazz", null },
                    { 3, "Rock", null },
                    { 4, "Soul-Funk-Disco", null }
                });

            migrationBuilder.InsertData(
                table: "MusicAlbums",
                columns: new[] { "MusicAlbumId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsMusicAlbumOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://p2c.xplace.de/mediastreaming/309e1b7704f3fd8f44a42b3dafda5fce24ee1e584a149bf00c4894ecce1b502593715f587dc65e66c7ee8eaf2be51018?skey=-get-ws-", "https://p2c.xplace.de/mediastreaming/309e1b7704f3fd8f44a42b3dafda5fce24ee1e584a149bf00c4894ecce1b502593715f587dc65e66c7ee8eaf2be51018?skey=-get-ws-", true, true, "Random Access Memories is the fourth studio album by French electronic music duo Daft Punk, released on 17 May 2013 by Daft Life and Columbia Records.", "Random Access Memories", 9.9900000000000002, "Studio album by Daft Punk" },
                    { 7, 1, "https://img.discogs.com/s3yi8HkyqdGoOKEsp4-6G-M9sO8=/fit-in/574x567/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-652096-1243886836.jpeg.jpg", "https://img.discogs.com/s3yi8HkyqdGoOKEsp4-6G-M9sO8=/fit-in/574x567/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-652096-1243886836.jpeg.jpg", true, false, "Collected is a compilation album by British trip hop collective Massive Attack, released on 27 March 2006. The album was preceded by the release of the single 'Live with Me' on 13 March. It collects most of the band's singles up until this point.", "Collected", 6.9900000000000002, "Compilation album by Massive Attack" },
                    { 2, 2, "https://images-na.ssl-images-amazon.com/images/I/91968jEoKIL._SL1500_.jpg", "https://images-na.ssl-images-amazon.com/images/I/91968jEoKIL._SL1500_.jpg", true, true, "A Love Supreme is an album by American jazz saxophonist John Coltrane. He recorded it in one session on December 9, 1964, at Van Gelder Studio in Englewood Cliffs, New Jersey, leading a quartet featuring pianist McCoy Tyner, bassist Jimmy Garrison, and drummer Elvin Jones.", "A Love Supreme", 13.970000000000001, "Album by John Coltrane" },
                    { 10, 2, "https://images-na.ssl-images-amazon.com/images/I/51ggUsokV3L.jpg", "https://images-na.ssl-images-amazon.com/images/I/51ggUsokV3L.jpg", true, true, "Kind of Blue is a studio album by American jazz trumpeter Miles Davis. It was recorded on March 2 and April 22, 1959, at Columbia's 30th Street Studio in New York City, and released on August 17 of that year by Columbia Records.", "Kind Of Blue", 6.9900000000000002, "Studio album by Miles Davis" },
                    { 3, 3, "https://p2c.xplace.de/mediastreaming/c809b218646da5fc5bebc8e2e82205788548ed82b7c7d26bcf5e989f9d13db6da7e4f1aa571fac8fc7ee8eaf2be51018?skey=-get-ws-", "https://p2c.xplace.de/mediastreaming/c809b218646da5fc5bebc8e2e82205788548ed82b7c7d26bcf5e989f9d13db6da7e4f1aa571fac8fc7ee8eaf2be51018?skey=-get-ws-", true, false, "The Dark Side of the Moon is the eighth studio album by English rock band Pink Floyd, released on 1 March 1973 by Harvest Records.", "Dark Side Of The Moon", 29.989999999999998, "Studio album by Pink Floyd" },
                    { 5, 3, "https://d2s36jztkuk7aw.cloudfront.net/sites/default/files/styles/media_responsive_widest/public/tile/image/original_441.jpg?itok=bSu8Jojn&timestamp=1354886431", "https://d2s36jztkuk7aw.cloudfront.net/sites/default/files/styles/media_responsive_widest/public/tile/image/original_441.jpg?itok=bSu8Jojn&timestamp=1354886431", true, true, "Abbey Road is the eleventh studio album by English rock band the Beatles, released on 26 September 1969 by Apple Records. The recording sessions were the last in which all four Beatles participated.", "Abbey Road (Ltd. 50th Ann. Del.Ed.)", 26.989999999999998, "Album by The Beatles" },
                    { 6, 3, "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/Bohemian_Rhapsody_soundtrack.jpg/220px-Bohemian_Rhapsody_soundtrack.jpg", "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwiD18_XlYjmAhUAwAIHHYRYBp8QjRx6BAgBEAQ&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FBohemian_Rhapsody%3A_The_Original_Soundtrack&psig=AOvVaw20C8n--N6lwZvimmGb1EdN&ust=1574867748716840", true, false, "Bohemian Rhapsody: The Original Soundtrack is the soundtrack album to the 2018 biographical film of the same name. The soundtrack features several Queen songs and unreleased recordings including several tracks from the group's performance at Live Aid in 1985.", "Bohemian Rhapsody", 15.98, "Soundtrack album by Queen" },
                    { 4, 4, "https://p2c.xplace.de/mediastreaming/97dfccd0e349eef43bb50291f81baf34a657d337e7b585e63547c8df537b15e2fa11b666724a8cfcc7ee8eaf2be51018?skey=-get-ws-", "https://p2c.xplace.de/mediastreaming/97dfccd0e349eef43bb50291f81baf34a657d337e7b585e63547c8df537b15e2fa11b666724a8cfcc7ee8eaf2be51018?skey=-get-ws-", true, false, "What's Going On is the eleventh studio album by American soul singer, songwriter, and producer Marvin Gaye. It was released on May 21, 1971, by the Motown Records-subsidiary label Tamla.", "What's Going On", 6.9900000000000002, "Studio album by Marvin Gaye" },
                    { 8, 4, "https://images-na.ssl-images-amazon.com/images/I/416CVJPhy%2BL._SY355_.jpg", "https://images-na.ssl-images-amazon.com/images/I/416CVJPhy%2BL._SY355_.jpg", true, false, "Love Songs is a 2003 album by Barry White.", "Love Songs", 9.9900000000000002, "Barry White album" },
                    { 9, 4, "https://www.bear-family.com/media/image/g0/80/d3/602498325841.jpg", "https://www.bear-family.com/media/image/g0/80/d3/602498325841.jpg", true, false, "40 tracks, recorded 1957-85, 16-page booklet incl. his biography and many pictures. ", "Gold", 11.99, "Album by James Brown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicAlbums_CategoryId",
                table: "MusicAlbums",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MusicAlbumId",
                table: "OrderDetails",
                column: "MusicAlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_MusicAlbumId",
                table: "ShoppingCartItems",
                column: "MusicAlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "MusicAlbums");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
