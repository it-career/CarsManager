﻿using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CarsManagerDb : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CarsManagerDb;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
