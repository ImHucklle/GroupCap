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


    }
}
