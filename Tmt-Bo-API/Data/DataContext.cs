using System;
using Microsoft.EntityFrameworkCore;
using Tmt_Bo_API.Entities;

namespace Tmt_Bo_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> users { get; set; }
    }
}

