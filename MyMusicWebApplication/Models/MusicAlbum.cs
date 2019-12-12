﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicWebApplication.Models
{
    public class MusicAlbum
    {
        public int MusicAlbumId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsMusicAlbumOfTheWeek { get; set; }

        public bool InStock { get; set; }

        public  int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
