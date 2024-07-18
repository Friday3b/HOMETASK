using _16._07._2024.Data;
using Microsoft.EntityFrameworkCore;
using _16._07._2024.Models.Concretes;

namespace _16._07._2024
{
    internal static class Program
    {
        static void Main()
        {
            //Application.Run(new Form1());

            Application.Run(new Form1()) ;

            //using (var dbContext = new AppDbContext())
            //{
            //    var product1 = new Product()
            //    {
            //        Id = 1,
            //        Name = "pepsi",
            //        Description = "delicious",
            //        Price = "5"
            //    };

            //    var product2 = new Product()
            //    {
            //        Id = 2, 
            //        Name = "cola",
            //        Description = "salty",
            //        Price = "10"
            //    };

            //    dbContext.Products.Add(product1);
            //    dbContext.Products.Add(product2);

            //    dbContext.SaveChanges();


            AppDbContext dbcontext = new AppDbContext();

            //var category = new Category()
            //{
            //    Id = 1,
            //    Name = "Drinks"
            //};


            //dbcontext.Categories.Add(category);
            //dbcontext.SaveChanges();





            var product3 = dbcontext.Products.Include(p => p.category).FirstOrDefault();
            Console.WriteLine(product3);














        }
    }
}

