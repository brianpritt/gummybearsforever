using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GummyBearsForever.Models
{
    [Table("GummyBears")]
    public class Inventory
    {   
        [Key]
        public int GummyId { get; set; }
        public string GummyName { get; set; }
        public int Cost { get; set; }
        public string Country { get; set; }

    }
}
