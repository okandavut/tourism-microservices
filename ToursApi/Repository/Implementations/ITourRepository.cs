using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Data.Entities;

namespace ToursApi.Repository.Implementations
{
    public interface ITourRepository
    {
        Task<IEnumerable<ToursEntity>> GetToursAsync();
        Task<bool> AddToursAsync(ToursEntity entity);
    }
}
