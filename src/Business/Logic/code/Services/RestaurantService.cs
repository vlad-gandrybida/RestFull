using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            return await RestaurantRepository.GetAll();
        }

        public Task<Restaurant> GetRestaurantById(string id)
        {
            return RestaurantRepository.GetById(id);
        }

        public async Task<Restaurant> AddNewRestaurant(Restaurant restaurant)
        {
            var entity = await RestaurantRepository.Add(restaurant);
            await RestaurantRepository.Commit();
            return entity;
        }
    }
}
