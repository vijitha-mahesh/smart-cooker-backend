using System.Collections.Generic;

namespace smartCooker.Models
{
    public class ProductOrder:BaseModel
    {
        public int Id { get; set; }
        public string Quentity { get; set; }

        public IList<Product> Products { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
