using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace MyMusicWebApplication.Models
{
    public class MusicAlbumDbAccessLayer
    {
        private readonly string connectionString =
            "Data Source=localhost;Initial Catalog=MyMusicWebApplication;Integrated Security=SSPI";
        
        public string AddMusicAlbum(MusicAlbum musicAlbum)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    musicAlbum = GetCategoryByCategoryId(musicAlbum);
                    con.Execute(
                        "INSERT INTO MusicAlbums VALUES(@Name, @ShortDescription, @LongDescription, @Price, @ImageUrl, @ImageThumbnailUrl, @IsMusicAlbumOfTheWeek, @InStock, @CategoryId)",
                        musicAlbum);
                    con.Close();
                    return ("Music album saved Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Count not insert.");
                return (ex.Message.ToString());
            }
        }

        private MusicAlbum GetCategoryByCategoryId(MusicAlbum musicAlbum)
        {
            Category tempCategory;

            switch (musicAlbum.Category.CategoryId)
            {
                case 1:
                    tempCategory = new Category
                        {CategoryId = 1, CategoryName = "Electronica", Description = "Electronica Albums"};
                    musicAlbum.Category = tempCategory;
                    musicAlbum.CategoryId = musicAlbum.Category.CategoryId;
                    break;
                case 2:
                    tempCategory = new Category
                        { CategoryId = 2, CategoryName = "Jazz", Description = "Jazz Albums" };
                    musicAlbum.Category = tempCategory;
                    musicAlbum.CategoryId = musicAlbum.Category.CategoryId;
                    break;
                case 3:
                    tempCategory = new Category
                        { CategoryId = 3, CategoryName = "Rock", Description = "Rock Albums" };
                    musicAlbum.Category = tempCategory;
                    musicAlbum.CategoryId = musicAlbum.Category.CategoryId;
                    break;
                case 4:
                    tempCategory = new Category
                        { CategoryId = 4, CategoryName = "Soul-Funk-Disco", Description = "Soul-Funk-Disco Albums" };
                    musicAlbum.Category = tempCategory;
                    musicAlbum.CategoryId = musicAlbum.Category.CategoryId;
                    break;
                default:
                    Console.WriteLine($"An unexpected value for CategoryId ({musicAlbum.Category.CategoryId})");
                    break;
            }
            return musicAlbum;
        }
    }
}
