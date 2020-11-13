using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Data;
using ToursApi.Data.Entities;
using ToursApi.Models;

namespace ToursApi.Repository.Implementations
{
    public class TourRepository : ITourRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public TourRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<ToursEntity>> GetToursAsync()
        {
            return await _dbContext.Tours.ToListAsync();
        }

        public async Task<bool> AddToursAsync(ToursEntity entity)
        {
            await _dbContext.Tours.AddAsync(entity);
            return await SaveAsync();
        }
    }
}
