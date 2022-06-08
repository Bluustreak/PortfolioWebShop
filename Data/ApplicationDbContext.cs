﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioWebShop.Models;

namespace PortfolioWebShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
    }
}