using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMusicWebApplication.Models;
using MyMusicWebApplication.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMusicWebApplication.Controllers
{
    public class MusicAlbumController : Controller
    {
        private readonly IMusicAlbumRepository _musicAlbumRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MusicAlbumController(IMusicAlbumRepository musicAlbumRepository, ICategoryRepository categoryRepository)
        {
            _musicAlbumRepository = musicAlbumRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Details(int id)
        {
            var musicAlbum = _musicAlbumRepository.GetMusicAlbumById(id);
            if (musicAlbum == null)
                return NotFound();
            return View(musicAlbum);
        }

        public ViewResult List(string category)
        {
            IEnumerable<MusicAlbum> musicAlbums;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                musicAlbums = _musicAlbumRepository.AllMusicAlbums.OrderBy(m => m.CategoryId);
                currentCategory = "All music albums";
            }
            else
            {
                musicAlbums = _musicAlbumRepository.AllMusicAlbums.Where(m => m.Category.CategoryName == category)
                    .OrderBy(m => m.MusicAlbumId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new MusicAlbumsListViewModel
            {
                MusicAlbums = musicAlbums,
                CurrentCategory = currentCategory
            });
        }
    }
}
