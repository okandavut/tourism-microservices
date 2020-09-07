using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
        public class HotelsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hotel 1", "Hotel 2 " };
        }
    }
}
