using System.ComponentModel.DataAnnotations;

namespace MyFavMusique.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
