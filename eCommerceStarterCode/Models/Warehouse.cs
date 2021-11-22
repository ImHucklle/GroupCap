using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        
        public int BookId { get; set; }

        public int Quantity { get; set; }
    }
}
