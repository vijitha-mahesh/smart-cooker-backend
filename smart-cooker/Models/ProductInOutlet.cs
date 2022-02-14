using System.Collections.Generic;

namespace smartCooker.Models
{
    public class ProductInOutlet
    {
        public int Id { get; set; }
        public int Quentity { get; set; }

        public Product Product { get; set; }
        public Outlet Outlet { get; set; }
    }
}
