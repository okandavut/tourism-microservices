using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToursApi.Data.Entities;

namespace ToursApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<ToursEntity> Tours { get; set; }
        public virtual DbSet<SoldToursEntity> SoldTours { get; set; }

    }
}