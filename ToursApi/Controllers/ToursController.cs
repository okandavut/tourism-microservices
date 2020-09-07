using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToursApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
       public class ToursController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Tour 1", "Tour 2 " };
        }
    }
}
