using _16._07._2024.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._07._2024.Models.Concretes
{
    public class Product :BaseEntity
    {

        public string? Name { get; set; } 
        public string? Description { get; set; } 
        public string? Price { get; set; }
        public Category? category { get; set; }

        
    }
}
