﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Restaurant.Domain.Entities
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

