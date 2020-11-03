using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MfpeDrugsApi.Models
{
    public class Drug
    {
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }
        [Required]
        [Display(Name = "ManuactureDate")]

        public DateTime ManufactureDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public string ManufacturerName { get; set; }
        public DrugLocation DrugLocation { get; set; }
        [Required]
        public int DrugId { get; set; }
    }
}
