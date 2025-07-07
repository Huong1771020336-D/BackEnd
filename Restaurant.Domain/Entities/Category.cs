using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Type { get; set; }       
        public string? Description { get; set; }

        public ICollection<FoodItem>? FoodItems { get; set; }
        public ICollection<BlogPost>? BlogPosts { get; set; }
        public ICollection<Service>? Services { get; set; }
        public ICollection<GalleryImage>? GalleryImages { get; set; }
    }
}

