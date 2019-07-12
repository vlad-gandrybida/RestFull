using System;
using System.Collections.Generic;
using System.Text;
using RestFull.Business.Interfaces.Services;
using RestFull.Data.Entities.Restaurant;
using RestFull.Data.Interfaces.Repository;

namespace RestFull.Business.Logic.Services
{
    public class RestaurantService : IRestaurantService
    {
        private IRestaurantRepository RestaurantRepository { get; }
        private ITableRepository TableRepository { get; }

        public RestaurantService(IRestaurantRepository restaurantRepository, ITableRepository tableRepository)
        {
            RestaurantRepository = restaurantRepository;
            TableRepository = tableRepository;
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return RestaurantRepository.GetAll();
        }

        public Restaurant AddNewRestaurant(Restaurant restaurant)
        {
            var entity = RestaurantRepository.Add(restaurant);
            RestaurantRepository.Commit();
            return entity;
        }
    }
}
