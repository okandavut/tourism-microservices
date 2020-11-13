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

            return StatusCode((int)HttpStatusCode.OK, response);
        }

        [HttpGet]
        public async Task<IActionResult> AddTours(AddTourRequest request)
        {
            var response = await _tourService.AddToursAsync(request);
            return StatusCode(response.StatusCode, response);
        }
    }
}
