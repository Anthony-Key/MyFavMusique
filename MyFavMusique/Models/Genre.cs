using System.ComponentModel.DataAnnotations;

namespace MyFavMusique.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
