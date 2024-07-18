using _16._07._2024.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._07._2024.Models.Concretes
{
    public class Category :BaseEntity
    {
        public string? Name { get; set; }
        

        public ICollection<Product>? Products { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
