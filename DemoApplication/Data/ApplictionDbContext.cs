using DemoApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Data
{
    public class ApplictionDbContext : DbContext
    {

        public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) :  base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }

    }
}
