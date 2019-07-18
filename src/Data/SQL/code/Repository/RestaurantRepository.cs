using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestFull.Data.Entities.Restaurant;
using RestFull.Data.Interfaces.Repository;

namespace RestFull.Data.SQL.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private RestFullDbContext Database { get; }

        public RestaurantRepository(RestFullDbContext db)
        {
            Database = db;
        }

        public async Task<IEnumerable<Restaurant>> GetAll()
        {
            return Database.Restaurants.AsEnumerable();
        }

        public async Task<Restaurant> GetById(string id)
        {
            return await Database.Restaurants.FirstOrDefaultAsync(restaurant => restaurant.Id == id);
        }

        public async Task<Restaurant> Add(Restaurant item)
        {
            var entity = await Database.Restaurants.AddAsync(item);

            return entity.Entity;
        }

        public async  Task<Restaurant> Update(Restaurant item)
        {
            var entity = Database.Restaurants.Attach(item);

            entity.State = EntityState.Modified;

            return item;
        }

        public async Task<Restaurant> Delete(Restaurant item)
        {
            var entity = await Database.Restaurants.FirstOrDefaultAsync(r => r.Id == item.Id);

            if (entity != null)
            {
                Database.Restaurants.Remove(entity);
            }

            return entity;
        }

        public async Task<int> Commit()
        {
            return Database.SaveChanges();
        }
    }
}
