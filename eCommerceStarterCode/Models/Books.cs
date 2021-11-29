using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Genre { get; set; }

        public int ReleaseDate { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }
        //public object UserId { get; internal set; }
        //public object Genres { get; internal set; }
        //public object Name { get; internal set; }
        //public int Id { get; internal set; }
    }
}
