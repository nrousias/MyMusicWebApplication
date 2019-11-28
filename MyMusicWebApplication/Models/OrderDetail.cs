using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicWebApplication.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int MusicAlbumId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public MusicAlbum MusicAlbum { get; set; }
        public Order Order { get; set; }
    }
}
