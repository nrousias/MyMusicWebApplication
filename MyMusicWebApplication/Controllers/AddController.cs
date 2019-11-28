using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMusicWebApplication.Models;

namespace MyMusicWebApplication.Controllers
{
    public class AddController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        MusicAlbumDbAccessLayer madb = new MusicAlbumDbAccessLayer();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveMusicAlbum([Bind] MusicAlbum musicAlbum)
        {
            string resp = madb.AddMusicAlbum(musicAlbum);
            TempData["msg"] = resp;
            
            return View();
        }
    }

}
