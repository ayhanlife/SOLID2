using System.ComponentModel.DataAnnotations.Schema;

namespace SOLID2.Core.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }


        public int CategoryId { get; set; }
        //[ForeignKey("Category_Id")]// Category ForeignKey standart dışı kullanım
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
