using System.Collections.Generic;

namespace smartCooker.Models
{
    public class ProductOrder:BaseModel
    {
        public int Id { get; set; }
        public int Quentity { get; set; }
        public int Product_Order_Qty { get; set; }

        public ProductInOutlet ProductInOutlet { get; set; }
        public Order Orders { get; set; }
    }
}
