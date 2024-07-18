using Microsoft.EntityFrameworkCore;
using _16._07._2024.Models.Concretes;

namespace _16._07._2024.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-G936QCF;Initial Catalog=newDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }
    
   public  DbSet <Product>Products { get; set;  }
   public  DbSet <Category>Categories { get; set; } 

    //buradaki dbset ler bizim database deki table larimizdir. 

    

}
