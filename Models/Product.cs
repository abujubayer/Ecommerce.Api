using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.API.Models
{
    public class Product
    {
        //internal readonly object Category;

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        
        //  public virtual Category Category { get; set; }
    }
}
