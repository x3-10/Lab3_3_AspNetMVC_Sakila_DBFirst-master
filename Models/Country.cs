using System;
using System.Collections.Generic;

namespace Lab3_3_AspNetMVC_Sakila_DBFirst.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public short CountryId { get; set; }
        public string Country1 { get; set; }
        public DateTime? LastUpdate { get; set; }

        public ICollection<City> City { get; set; }
    }
}
