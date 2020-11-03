using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MfpeDrugsApi.Models
{
    public class DrugLocation
    {
        public int Id { get; set; }
        [Key]
        public int DrugId { get; set; }

        [Required]
        public string Location { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
