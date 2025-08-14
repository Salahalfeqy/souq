using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace souq.Models
{
    public class ProductVm
    {

        
        [Required]
        public string CatName { get; set; }
        [Required]
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    
        public int ProductQty { get; set; }
    }
}
