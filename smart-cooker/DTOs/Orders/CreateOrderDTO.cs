using System.Collections.Generic;

namespace smartCooker.DTOs.Orders
{
    public class CreateOrderDTO
    {
        public int UserId { get; set; }
        public int OutletID { get; set; }
        public int ProductId { get; set; }
        public int Quentity { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "in_progress";
    }
}
