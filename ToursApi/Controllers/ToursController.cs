using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ToursApi.Models;
using ToursApi.Services;

namespace ToursApi.Controllers
{
    [ApiController]
    [Route("Tours")]
    public class ToursController : ControllerBase
    {
        private readonly ITourService _tourService;

        public ToursController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTours()
        {
            var response = await _tourService.GetToursAsync();
            if (response == null)
            {
                return BadRequest();
            }

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost, Route("AddTour")]
        public async Task<IActionResult> AddTours([FromBody] AddTourRequest request)
        {
            var response = await _tourService.AddToursAsync(request);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet,Route("tourbyid")]
        public async Task<IActionResult> GetTourById([FromBody] GetTourByIdRequest request)
        {
            var response = await _tourService.GetTourByIdAsync(request);
            return StatusCode(response.StatusCode, response);
        }
    }
}
