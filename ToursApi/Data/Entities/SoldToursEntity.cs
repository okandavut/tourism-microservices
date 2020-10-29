using Otiport.API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToursApi.Data.Entities
{
    [Table("SoldTours")]
    public class SoldToursEntity : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int? TourId { get; set; }
        public ToursEntity Tour { get; set; }
    }
}
