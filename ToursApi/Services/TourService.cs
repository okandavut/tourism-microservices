using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Models;
using ToursApi.Repository.Implementations;

namespace ToursApi.Services
{
    public class TourService : ITourService
    {
        private readonly ITourRepository _tourRepository;
        public TourService(ITourRepository tourRepository)
        {
            _tourRepository = tourRepository;
        }

        public async Task<GetToursResponse> GetToursAsync()
        {
            var response = new GetToursResponse();
            response.Tours = await _tourRepository.GetToursAsync();
            return response;
        }
    }
}
