﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GolClinics.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        public string Brand { get; set; }
        [Required]
        public double Price { get; set; }

        public Stock()
        {
                
        }
    }
}
