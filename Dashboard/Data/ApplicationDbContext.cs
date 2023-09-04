using System;
using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
	
public class ApplicationDbContext:DbContext
        {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
            {

            }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsDetails> ProductsDetails { get; set; }
        public DbSet<Customers> Custumer { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<PaymentAccept> PaymentAccept { get; set; }
        
    }
    }
	


