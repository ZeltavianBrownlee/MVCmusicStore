using System.ComponentModel.DataAnnotations;

namespace MvcMusic.Models
{
    public class ArtistModel
    {
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}