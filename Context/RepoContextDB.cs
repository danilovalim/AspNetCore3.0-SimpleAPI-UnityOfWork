using Microsoft.EntityFrameworkCore;
using RepoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoApp.Context
{
    public class RepoContextDB : DbContext
    {
        public RepoContextDB(DbContextOptions<RepoContextDB> options)
            :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
