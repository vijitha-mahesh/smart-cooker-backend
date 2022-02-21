using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace smartCooker.Models
{
    public class Order:BaseModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = string.Empty;
        public IList<ProductOrder> ProductOrder { get; set; }
        public IdentityUserModel User { get; set; }
        public Outlet Outlet { get; set; } 

    }
}
