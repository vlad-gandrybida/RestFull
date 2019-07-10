using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Restaurant> GetAll()
        {
            return Database.Restaurants.AsEnumerable();
        }

        public Restaurant GetById(int id)
        {
            return Database.Restaurants.FirstOrDefault(restaurant => restaurant.ID == id);
        }

        public Restaurant Add(Restaurant item)
        {
            var entity = Database.Restaurants.Add(item);

            return entity.Entity;
        }

        public Restaurant Update(Restaurant item)
        {
            var entity = Database.Restaurants.Attach(item);

            entity.State = EntityState.Modified;

            return item;
        }

        public Restaurant Delete(Restaurant item)
        {
            var entity = Database.Restaurants.FirstOrDefault(r => r.ID == item.ID);

            if (entity != null)
            {
                Database.Restaurants.Remove(entity);
            }

            return entity;
        }

        public int Commit()
        {
            return Database.SaveChanges();
        }
    }
}
