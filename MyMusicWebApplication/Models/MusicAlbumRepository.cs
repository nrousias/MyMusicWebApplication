using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyMusicWebApplication.Models
{
    public class MusicAlbumRepository: IMusicAlbumRepository
    {
        private readonly AppDbContext _appDbContext;

        public MusicAlbumRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<MusicAlbum> AllMusicAlbums
        {
            get { return _appDbContext.MusicAlbums.Include(c => c.Category); }
        }

        public IEnumerable<MusicAlbum> MusicAlbumsOfTheWeek
        {
            get { return _appDbContext.MusicAlbums.Include(c => c.Category).Where(m => m.IsMusicAlbumOfTheWeek); }
        }

        public MusicAlbum GetMusicAlbumById(int id)
        {
            return _appDbContext.MusicAlbums.FirstOrDefault(m => m.MusicAlbumId == id);
        }
    }
}
