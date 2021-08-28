using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FathymaPieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string PieName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string NafdacNumber { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek  { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
