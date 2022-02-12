using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
 