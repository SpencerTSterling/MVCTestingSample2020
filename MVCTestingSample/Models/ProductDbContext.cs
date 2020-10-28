using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestingSample.Models
{
    public class ProductDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }
    }
}
