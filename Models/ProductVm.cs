using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace souq.Models
{
    public class ProductVm
    {

        [Display(Name = "Category Name")]
        [Required]
        public string CatName { get; set; }

        [Display(Name = "Product Name")]
        [Required]
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    
        public decimal ProductQty { get; set; }
    }
}
