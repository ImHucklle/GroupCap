using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        [Key, Column(Order = 1)]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; }

        public int Quantity { get; set; }

    }
}
