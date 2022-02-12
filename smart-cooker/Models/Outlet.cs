using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace smartCooker.Models
{
    public class Outlet:BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public IList<UserWorksInOutlet> userWorksInOutlets { get; set; }
        public IList<ProductInOutlet> ProductInOutlet { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
