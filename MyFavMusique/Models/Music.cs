using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFavMusique.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        [ForeignKey("GenreId")]
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public Music()
        {

        }

        public Music(Genre g)
        {
            Genre = g;
        }
    }
}
