using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsApi.Data;
using HotelsApi.Data.Entities;
using HotelsApi.Models;

namespace HotelsApi.Repository.Implementations
{
    public class HotelRepository : IHotelRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public HotelRepository(ApplicationDbContext dbContext)
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

        public async Task<IEnumerable<HotelsEntity>> GetHotelsAsync()
        {
            return await _dbContext.Hotels.ToListAsync();
        }

        public async Task<bool> AddHotelsAsync(HotelsEntity entity)
        {
            await _dbContext.Hotels.AddAsync(entity);
            return await SaveAsync();
        }

        public async Task<HotelsEntity> GetHotelByIdAsync(int Id)
        {
            return await _dbContext.Hotels.FindAsync(Id);
        }

    }
}
