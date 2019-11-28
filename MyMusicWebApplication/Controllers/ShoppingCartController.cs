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
    public class ShoppingCartController : Controller
    {
        private readonly IMusicAlbumRepository _musicAlbumRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMusicAlbumRepository musicAlbumRepository, ShoppingCart shoppingCart)
        {
            _musicAlbumRepository = musicAlbumRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int musicAlbumId)
        {
            var selectedMusicAlbum = _musicAlbumRepository.AllMusicAlbums.FirstOrDefault(m => m.MusicAlbumId == musicAlbumId);

            if (selectedMusicAlbum != null)
            {
                _shoppingCart.AddToCart(selectedMusicAlbum, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int musicAlbumId)
        {
            var selectedMusicAlbum  = _musicAlbumRepository.AllMusicAlbums.FirstOrDefault(m => m.MusicAlbumId == musicAlbumId);

            if (selectedMusicAlbum != null)
            {
                _shoppingCart.RemoveFromCart(selectedMusicAlbum);
            }
            return RedirectToAction("Index");
        }
    }
}
