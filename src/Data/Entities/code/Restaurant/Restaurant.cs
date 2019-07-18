using System;
using System.Collections.Generic;
using System.Text;
using RestFull.Common.Enums;
using RestFull.Common.Enums.Restaurant;

namespace RestFull.Data.Entities.Restaurant
{
    public class Restaurant : BaseEntity
    {
        public RestaurantState State { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public int AverageOrderPrice { get; set; }

        public string Description { get; set; }

        public List<Table> Tables { get; set; }

        public Restaurant()
        {
            Tables = new List<Table>();
        }
    }
}
