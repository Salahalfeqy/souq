using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace souq.Models
{
    
    public class indexVm
    {
        public indexVm()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
            LatestProducts = new List<Product>();
            Reviews = new List<Review>();
        }
        public List<Category> Categories{ get; set; }
        public List<Product> Products{ get; set; }
        public List<Product> LatestProducts{ get; set; }
        public List<Review> Reviews{ get; set; }
    }
}
