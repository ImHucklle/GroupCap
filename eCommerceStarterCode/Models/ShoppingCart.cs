using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }

        public int UserId { get; set; }

        public int Quantity { get; set; }

    }
}
