using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Data.Entities;

namespace ToursApi.Models
{
    public class AddTourRequest
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public decimal Price { get; set; }
        public int Count{ get; set; }
    }
}
