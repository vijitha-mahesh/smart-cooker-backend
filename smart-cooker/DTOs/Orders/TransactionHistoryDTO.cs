using System;

namespace smartCooker.DTOs.Orders
{
    public class TransactionHistoryDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int OutletId { get; set; }
        public string OutletName { get; set; }
        public DateTime dateTime { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } 

    }
}
