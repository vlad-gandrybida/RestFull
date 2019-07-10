using System;
using System.Collections.Generic;
using System.Text;
using RestFull.Common.Enums;

namespace RestFull.Data.Entities.Restaurant
{
    public class Restaurant : BaseEntity
    {
        public RestaurantState State { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
        
        public List<Table> Tables { get; set; }

        public Restaurant()
        {
            Tables = new List<Table>();
        }

    }
}
