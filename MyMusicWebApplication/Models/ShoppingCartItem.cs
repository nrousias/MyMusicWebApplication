﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicWebApplication.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public MusicAlbum MusicAlbum { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
