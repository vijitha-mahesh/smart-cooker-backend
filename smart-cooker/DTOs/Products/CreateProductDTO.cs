﻿namespace smartCooker.DTOs.Products
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; }
        public decimal Quentity { get; set; }
    }
}
