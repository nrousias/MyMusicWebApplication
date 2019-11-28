using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicWebApplication.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            { 
                new Category { CategoryId = 1, CategoryName = "Electronica", Description = "Electronica Albums" },
                new Category { CategoryId = 2, CategoryName = "Jazz", Description = "Jazz Albums" },
                new Category { CategoryId = 3, CategoryName = "Rock", Description = "Rock Albums" },
                new Category { CategoryId = 4, CategoryName = "Soul-Funk-Disco", Description = "Soul-Funk-Disco Albums" }
            };
    }
}
