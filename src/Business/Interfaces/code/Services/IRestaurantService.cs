﻿using System.Collections.Generic;
using System.Threading.Tasks;
using RestFull.Data.Entities.Restaurant;

namespace RestFull.Business.Interfaces.Services
{
    public interface IRestaurantService
    {
        Task<Restaurant> AddNewRestaurant(Restaurant restaurant);

        Task<IEnumerable<Restaurant>> GetRestaurants();

        Task<Restaurant> GetRestaurantById(string id);
    }
}
