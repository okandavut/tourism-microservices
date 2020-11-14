using HotelsApi.API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Data.Entities
{
    [Table("SoldHotels")]
    public class SoldHotelsEntity : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int? HotelId { get; set; }
        public HotelsEntity Hotel { get; set; }
    }
}
