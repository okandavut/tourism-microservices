using HotelsApi.API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Data.Entities
{
    [Table("Hotels")]
    public class HotelsEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public decimal Price { get; set; }
        public int Count{ get; set; }

    }
}