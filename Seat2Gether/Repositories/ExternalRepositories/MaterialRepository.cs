using Seat2Gether.Models;
using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Seat2Gether.Repositories.ExternalRepositories
{
   public class MaterialRepository
   {
      private Seat2GetherDBContext DBContext = null;

      public MaterialRepository()
      {
         DBContext = new Seat2GetherDBContext();
      }

      public IQueryable<ExVehicleMaterial> GetList()
      {
         return DBContext.ExVehicleMaterial.AsQueryable();
      }

      public ExVehicleMaterial Get(Expression<Func<ExVehicleMaterial,bool>> predicate)
      {
         return DBContext.ExVehicleMaterial.SingleOrDefault(predicate);
      }

      public ExVehicleMaterial Find(object[] Id)
      {
         return DBContext.ExVehicleMaterial.Find(Id);
      }
      public void Add(ExVehicleMaterial entity)
      {
         DBContext.ExVehicleMaterial.Add(entity);
         DBContext.SaveChanges();
      }
      public void AddRange(IEnumerable<ExVehicleMaterial> entity)
      {
         DBContext.ExVehicleMaterial.AddRange(entity);
         DBContext.SaveChanges();
      }
      public void Update(ExVehicleMaterial entity)
      {
         DBContext.Entry(entity).State = EntityState.Modified;
         DBContext.SaveChanges();
      }

      public void Delete(ExVehicleMaterial entity)
      {
         DBContext.ExVehicleMaterial.Remove(entity);
         DBContext.SaveChanges();
      }
   }
}