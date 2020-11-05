using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Data.Entities;

namespace ToursApi.Models
{
    public class GetToursResponse
    {
        public IEnumerable<ToursEntity> Tours { get; set; }  
    }
}
