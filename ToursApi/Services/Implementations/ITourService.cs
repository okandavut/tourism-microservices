using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Models;

namespace ToursApi.Services
{
    public interface ITourService
    {
        Task<GetToursResponse> GetToursAsync();
    }
}
