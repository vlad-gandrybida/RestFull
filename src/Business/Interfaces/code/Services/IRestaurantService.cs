using System;
using System.Collections.Generic;
using System.Text;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Business.Interfaces.Services
{
    public interface IRestaurantService
    {
        Restaurant AddNewRestaurant(Restaurant restaurant);

        IEnumerable<Restaurant> GetRestaurants();
    }
}
