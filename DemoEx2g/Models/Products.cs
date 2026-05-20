using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx2g.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } = "";
        public string? Unit { get; set; }
        public double Price {get; set; }
        public string? Provider {  get; set; }
        public string? Creater { get; set; } 
        public string? Category { get; set; }
        public int Discount { get; set; }    
        public int Count { get; set; }
        public string? Photo { get; set; }
    }
}
