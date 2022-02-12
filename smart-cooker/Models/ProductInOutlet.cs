using System.Collections.Generic;

namespace smartCooker.Models
{
    public class ProductInOutlet
    {
        public int Id { get; set; }
        public int Quentity { get; set; }

        public IList<Product> Product { get; set; }
        public IList<Outlet> Outlet { get; set; }
    }
}
