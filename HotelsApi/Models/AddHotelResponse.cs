using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsApi.Data.Entities;

namespace HotelsApi.Models
{
    public class AddHotelResponse
    {
        public int StatusCode { get; set; } = 200;

        public bool IsSuccess => StatusCode >= 200 && StatusCode < 400;
    }
}
