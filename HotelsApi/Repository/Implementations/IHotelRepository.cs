using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsApi.Data.Entities;

namespace HotelsApi.Repository.Implementations
{
    public interface IHotelRepository
    {
        Task<IEnumerable<HotelsEntity>> GetHotelsAsync();
        Task<bool> AddHotelsAsync(HotelsEntity entity);
        Task<HotelsEntity> GetHotelByIdAsync(int Id);
    }
}
