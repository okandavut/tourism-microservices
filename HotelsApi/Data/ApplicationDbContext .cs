using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HotelsApi.Data.Entities;

namespace HotelsApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<HotelsEntity> Hotels { get; set; }
        public virtual DbSet<SoldHotelsEntity> SoldHotels { get; set; }

    }
}