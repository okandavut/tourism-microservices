using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsApi.Models;

namespace HotelsApi.Services
{
    public interface IHotelService
    {
        Task<GetHotelsResponse> GetHotelsAsync();
        Task<AddHotelResponse> AddHotelsAsync(AddHotelRequest request);
        Task<GetHotelByIdResponse> GetHotelByIdAsync(GetHotelByIdRequest request);
    }
}
