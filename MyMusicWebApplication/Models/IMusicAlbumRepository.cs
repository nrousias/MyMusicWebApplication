using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicWebApplication.Models
{
    public interface IMusicAlbumRepository
    {
        IEnumerable<MusicAlbum> AllMusicAlbums { get; }

        IEnumerable<MusicAlbum> MusicAlbumsOfTheWeek { get; }

        MusicAlbum GetMusicAlbumById(int id);
    }
}
