using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HotelsApi.Models;
using HotelsApi.Services;

namespace HotelsApi.Controllers
{
    [ApiController]
    [Route("Hotels")]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotels()
        {
            var response = await _hotelService.GetHotelsAsync();
            if (response == null)
            {
                return BadRequest();
            }

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost,Route("AddHotel")]
        public async Task<IActionResult> AddHotel([FromBody] AddHotelRequest request)
        {
            var response = await _hotelService.AddHotelsAsync(request);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet,Route("hotelbyid")]
        public async Task<IActionResult> GetHotelById([FromBody] GetHotelByIdRequest request)
        {
            var response = await _hotelService.GetHotelByIdAsync(request);
            return StatusCode(response.StatusCode, response);
        }
    }
}
