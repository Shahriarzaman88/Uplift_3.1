using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Uplift.Models
{
    public class Frequency
    {
        // Section 5 Assignment -01 Solution
        //Creating Class for Models

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Frequency Name")]
        public string Name { get; set; }

        [Required]
        public int FrequencyCount { get; set; }

        

    }
}
