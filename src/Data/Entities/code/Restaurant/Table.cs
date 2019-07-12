using System;
using System.Collections.Generic;
using System.Text;
using RestFull.Common.Enums;

namespace RestFull.Data.Entities.Restaurant
{
    public class Table : BaseEntity
    {
        public int NumberOfSeats { get; set; }

        public TableState State { get; set; }

        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
