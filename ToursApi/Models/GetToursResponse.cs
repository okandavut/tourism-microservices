﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToursApi.Data.Entities;

namespace ToursApi.Models
{
    public class GetToursResponse
    {
        public IEnumerable<ToursEntity> Tours { get; set; }
        public int StatusCode { get; set; } = 200;

        public bool IsSuccess => StatusCode >= 200 && StatusCode < 400;
    }
}
