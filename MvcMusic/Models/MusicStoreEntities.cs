using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace MvcMusic.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<AlbumModel> Albums { get; set;}
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<ArtistModel>Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }


}
