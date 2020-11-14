using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HotelsApi.Data.Entities;
using HotelsApi.Models;
using HotelsApi.Repository.Implementations;

namespace HotelsApi.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<GetHotelsResponse> GetHotelsAsync()
        {
            var response = new GetHotelsResponse();
            response.Hotels = await _hotelRepository.GetHotelsAsync();
            return response;
        }

        public async Task<AddHotelResponse> AddHotelsAsync(AddHotelRequest request)
        {
            var response = new AddHotelResponse();

            HotelsEntity entity = new HotelsEntity()
            {
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Price = request.Price,
                Count = request.Count
            };
            bool status = await _hotelRepository.AddHotelsAsync(entity);

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

        public async Task<GetHotelByIdResponse> GetHotelByIdAsync(GetHotelByIdRequest request)
        {
            var response = new GetHotelByIdResponse();
            response.Hotel = await _hotelRepository.GetHotelByIdAsync(request.Id);
            return response;
        }
    }
}
