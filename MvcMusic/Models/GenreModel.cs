using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusic.Models
{
    public partial class GenreModel
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public List<AlbumModel> Albums { get; set; }
    }
}