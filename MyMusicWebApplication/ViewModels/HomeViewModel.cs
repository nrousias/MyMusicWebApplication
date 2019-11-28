using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMusicWebApplication.Models;

namespace MyMusicWebApplication.ViewModels
{
    public class HomeViewModel
    {
        public  IEnumerable<MusicAlbum> MusicAlbumsOfTheWeek { get; set; }
    }
}
