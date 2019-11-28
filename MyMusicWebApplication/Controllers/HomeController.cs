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
    public class HomeController : Controller
    {
        private readonly IMusicAlbumRepository _musicAlbumRepository;

        public HomeController(IMusicAlbumRepository musicAlbumRepository)
        {
            _musicAlbumRepository = musicAlbumRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MusicAlbumsOfTheWeek = _musicAlbumRepository.MusicAlbumsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
