using System;

namespace smartCooker.Models
{
    public class BaseModel
    {
        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

        public DateTime? Deleted { get; set; }
    }
}
 