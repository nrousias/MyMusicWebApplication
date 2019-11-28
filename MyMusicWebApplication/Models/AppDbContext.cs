using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyMusicWebApplication.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MusicAlbum> MusicAlbums { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 1, CategoryName = "Electronica"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 2, CategoryName = "Jazz"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 3, CategoryName = "Rock"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 4, CategoryName = "Soul-Funk-Disco"});

            //seed musicAlbums

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 1,
                Name = "Random Access Memories",
                Price = 9.99,
                ShortDescription = "Studio album by Daft Punk",
                LongDescription =
                    "Random Access Memories is the fourth studio album by French electronic music duo Daft Punk, released on 17 May 2013 by Daft Life and Columbia Records.",
                CategoryId = 1,
                ImageUrl =
                    "https://p2c.xplace.de/mediastreaming/309e1b7704f3fd8f44a42b3dafda5fce24ee1e584a149bf00c4894ecce1b502593715f587dc65e66c7ee8eaf2be51018?skey=-get-ws-",
                InStock = true,
                IsMusicAlbumOfTheWeek = true,
                ImageThumbnailUrl =
                    "https://p2c.xplace.de/mediastreaming/309e1b7704f3fd8f44a42b3dafda5fce24ee1e584a149bf00c4894ecce1b502593715f587dc65e66c7ee8eaf2be51018?skey=-get-ws-"
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 2,
                Name = "A Love Supreme",
                Price = 13.97,
                ShortDescription = "Album by John Coltrane",
                LongDescription =
                    "A Love Supreme is an album by American jazz saxophonist John Coltrane. He recorded it in one session on December 9, 1964, at Van Gelder Studio in Englewood Cliffs, New Jersey, leading a quartet featuring pianist McCoy Tyner, bassist Jimmy Garrison, and drummer Elvin Jones.",
                CategoryId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91968jEoKIL._SL1500_.jpg",
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/91968jEoKIL._SL1500_.jpg",
                InStock = true,
                IsMusicAlbumOfTheWeek = true
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 3,
                Name = "Dark Side Of The Moon",
                Price = 29.99,
                ShortDescription = "Studio album by Pink Floyd",
                LongDescription =
                    "The Dark Side of the Moon is the eighth studio album by English rock band Pink Floyd, released on 1 March 1973 by Harvest Records.",
                CategoryId = 3,
                ImageUrl =
                    "https://p2c.xplace.de/mediastreaming/c809b218646da5fc5bebc8e2e82205788548ed82b7c7d26bcf5e989f9d13db6da7e4f1aa571fac8fc7ee8eaf2be51018?skey=-get-ws-",
                ImageThumbnailUrl =
                    "https://p2c.xplace.de/mediastreaming/c809b218646da5fc5bebc8e2e82205788548ed82b7c7d26bcf5e989f9d13db6da7e4f1aa571fac8fc7ee8eaf2be51018?skey=-get-ws-",
                InStock = true,
                IsMusicAlbumOfTheWeek = false
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 4,
                Name = "What's Going On",
                Price = 6.99,
                ShortDescription = "Studio album by Marvin Gaye",
                LongDescription =
                    "What's Going On is the eleventh studio album by American soul singer, songwriter, and producer Marvin Gaye. It was released on May 21, 1971, by the Motown Records-subsidiary label Tamla.",
                CategoryId = 4,
                ImageUrl =
                    "https://p2c.xplace.de/mediastreaming/97dfccd0e349eef43bb50291f81baf34a657d337e7b585e63547c8df537b15e2fa11b666724a8cfcc7ee8eaf2be51018?skey=-get-ws-",
                ImageThumbnailUrl =
                    "https://p2c.xplace.de/mediastreaming/97dfccd0e349eef43bb50291f81baf34a657d337e7b585e63547c8df537b15e2fa11b666724a8cfcc7ee8eaf2be51018?skey=-get-ws-",
                InStock = true,
                IsMusicAlbumOfTheWeek = false,
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 5,
                Name = "Abbey Road (Ltd. 50th Ann. Del.Ed.)",
                Price = 26.99,
                ShortDescription = "Album by The Beatles",
                LongDescription = "Abbey Road is the eleventh studio album by English rock band the Beatles, released on 26 September 1969 by Apple Records. The recording sessions were the last in which all four Beatles participated.",
                CategoryId = 3,
                ImageUrl = "https://d2s36jztkuk7aw.cloudfront.net/sites/default/files/styles/media_responsive_widest/public/tile/image/original_441.jpg?itok=bSu8Jojn&timestamp=1354886431",
                ImageThumbnailUrl = "https://d2s36jztkuk7aw.cloudfront.net/sites/default/files/styles/media_responsive_widest/public/tile/image/original_441.jpg?itok=bSu8Jojn&timestamp=1354886431",
                InStock = true,
                IsMusicAlbumOfTheWeek = true
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 6, 
                Name = "Bohemian Rhapsody", 
                Price = 15.98, 
                ShortDescription = "Soundtrack album by Queen", 
                LongDescription = "Bohemian Rhapsody: The Original Soundtrack is the soundtrack album to the 2018 biographical film of the same name. The soundtrack features several Queen songs and unreleased recordings including several tracks from the group's performance at Live Aid in 1985.",
                CategoryId = 3,
                ImageUrl = "https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=2ahUKEwiD18_XlYjmAhUAwAIHHYRYBp8QjRx6BAgBEAQ&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FBohemian_Rhapsody%3A_The_Original_Soundtrack&psig=AOvVaw20C8n--N6lwZvimmGb1EdN&ust=1574867748716840", 
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/Bohemian_Rhapsody_soundtrack.jpg/220px-Bohemian_Rhapsody_soundtrack.jpg", 
                InStock=true, 
                IsMusicAlbumOfTheWeek=false
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 7, 
                Name = "Collected", 
                Price = 6.99, 
                ShortDescription = "Compilation album by Massive Attack", 
                LongDescription = "Collected is a compilation album by British trip hop collective Massive Attack, released on 27 March 2006. The album was preceded by the release of the single 'Live with Me' on 13 March. It collects most of the band's singles up until this point.",
                CategoryId = 1,
                ImageUrl = "https://img.discogs.com/s3yi8HkyqdGoOKEsp4-6G-M9sO8=/fit-in/574x567/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-652096-1243886836.jpeg.jpg", 
                ImageThumbnailUrl = "https://img.discogs.com/s3yi8HkyqdGoOKEsp4-6G-M9sO8=/fit-in/574x567/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-652096-1243886836.jpeg.jpg", 
                InStock=true, 
                IsMusicAlbumOfTheWeek=false
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 8, 
                Name = "Love Songs", 
                Price = 9.99, 
                ShortDescription = "Barry White album", 
                LongDescription = "Love Songs is a 2003 album by Barry White.",
                CategoryId = 4,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/416CVJPhy%2BL._SY355_.jpg", 
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/416CVJPhy%2BL._SY355_.jpg", 
                InStock=true, 
                IsMusicAlbumOfTheWeek=false
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 9, 
                Name = "Gold", 
                Price = 11.99, 
                ShortDescription = "Album by James Brown", 
                LongDescription = "40 tracks, recorded 1957-85, 16-page booklet incl. his biography and many pictures. ",
                CategoryId = 4,
                ImageUrl = "https://www.bear-family.com/media/image/g0/80/d3/602498325841.jpg", 
                ImageThumbnailUrl = "https://www.bear-family.com/media/image/g0/80/d3/602498325841.jpg", 
                InStock=true, 
                IsMusicAlbumOfTheWeek=false
            });

            modelBuilder.Entity<MusicAlbum>().HasData(new MusicAlbum
            {
                MusicAlbumId = 10, 
                Name = "Kind Of Blue", 
                Price = 6.99, 
                ShortDescription = "Studio album by Miles Davis", 
                LongDescription = "Kind of Blue is a studio album by American jazz trumpeter Miles Davis. It was recorded on March 2 and April 22, 1959, at Columbia's 30th Street Studio in New York City, and released on August 17 of that year by Columbia Records.",
                CategoryId = 2,
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51ggUsokV3L.jpg", 
                ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/51ggUsokV3L.jpg", 
                InStock=true, 
                IsMusicAlbumOfTheWeek=true
            });
        }
    }
}
