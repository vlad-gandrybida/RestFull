using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RestFull.Common.Enums;
using RestFull.Data.Entities.Restaurant;
using RestFull.Data.Entities.User;

namespace RestFull.Data.SQL
{
    public class RestFullDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Table> Tables { get; set; }

        public RestFullDbContext(DbContextOptions<RestFullDbContext> options)
            :base(options)
        {
            
        }
    }
}
