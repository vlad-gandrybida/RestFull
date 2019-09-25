using RestFull.Common.Enums.Table;

namespace RestFull.Data.Entities.Restaurant
{
    public class Table : BaseEntity
    {
        public int NumberOfSeats { get; set; }

        public TableState State { get; set; }

        public string RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}
