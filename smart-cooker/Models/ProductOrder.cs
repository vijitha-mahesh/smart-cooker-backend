using System.Collections.Generic;

namespace smartCooker.Models
{
    public class ProductOrder:BaseModel
    {
        public int Id { get; set; }
        public string Quentity { get; set; }

        public Product Products { get; set; }
        public Order Orders { get; set; }
    }
}
