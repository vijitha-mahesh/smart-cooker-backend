using System.Collections.Generic;

namespace smartCooker.Models
{
    public class Product:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; }
        public decimal  Quentity { get; set; }


        public IList<ProductInOutlet> ProductInOutlet { get; set; }
        public IList<ProductOrder>  ProductOrder { get; set; }
    }
}
