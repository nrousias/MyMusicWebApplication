using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMusicWebApplication.Models;

namespace MyMusicWebApplication.ViewModels
{
    public class MusicAlbumsListViewModel
    {
        public IEnumerable<MusicAlbum> MusicAlbums { get; set; }

        public string CurrentCategory { get; set; }
    }
}
