using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.API.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Product")]
        public int ProductId {get; set;}
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
