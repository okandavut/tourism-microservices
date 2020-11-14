using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsApi.Data.Entities;

namespace HotelsApi.Models
{
    public class AddHotelRequest
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public decimal Price { get; set; }
        public int Count{ get; set; }
    }
}
