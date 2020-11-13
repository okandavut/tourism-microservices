using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ToursApi.Data.Entities;
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

        public async Task<AddTourResponse> AddToursAsync(AddTourRequest request)
        {
            var response = new AddTourResponse();

            ToursEntity entity = new ToursEntity()
            {
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Price = request.Price,
                Count = request.Count
            };
            bool status = await _tourRepository.AddToursAsync(entity);

            if (status)
            {
                response.StatusCode = (int)HttpStatusCode.Created;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            
            return response;
        }

        public async Task<GetTourByIdResponse> GetTourByIdAsync(GetTourByIdRequest request)
        {
            var response = new GetTourByIdResponse();
            response.Tour = await _tourRepository.GetTourByIdAsync(request.Id);
            return response;
        }
    }
}
