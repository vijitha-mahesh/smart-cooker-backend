﻿namespace smartCooker.Models
{
    public class UserAddress:BaseModel
    {
        public int Id { get; set; }
        public string Address { get; set; } 
        public IdentityUserModel IdentityUserModel { get; set; }
    }
}