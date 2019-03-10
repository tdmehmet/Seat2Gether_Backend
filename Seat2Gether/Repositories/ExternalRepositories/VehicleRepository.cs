using Seat2Gether.Models;
using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories.ExternalRepositories
{
    public class VehicleRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public VehicleRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public IQueryable<ExVehicle> GetList()
        {
            return DBContext.ExVehicle.AsQueryable();
        }
        public ExVehicle Find(params object[] Id)
        {
            return DBContext.ExVehicle.Find(Id);
        }
        public void Add(ExVehicle entity)
        {
            DBContext.ExVehicle.Add(entity);
            DBContext.SaveChanges();
        }
        public void AddRange(IEnumerable<ExVehicle> entity)
        {
            DBContext.ExVehicle.AddRange(entity);
            DBContext.SaveChanges();
        }
        public void Update(ExVehicle entity)
        {
            DBContext.Entry(entity).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(ExVehicle entity)
        {
            DBContext.ExVehicle.Remove(entity);
            DBContext.SaveChanges();
        }
    }
}