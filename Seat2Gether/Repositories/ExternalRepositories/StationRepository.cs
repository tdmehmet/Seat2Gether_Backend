using Seat2Gether.Models;
using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories.ExternalRepositories
{
    public class StationRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public StationRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public IQueryable<ExStation> GetList()
        {
            return DBContext.ExStation.AsQueryable();
        }
        public ExStation Find(object Id)
        {
            return DBContext.ExStation.Find(Id);
        }
        public void Add(ExStation entity)
        {
            DBContext.ExStation.Add(entity);
            DBContext.SaveChanges();
        }
        public void AddRange(IEnumerable<ExStation> entity)
        {
            DBContext.ExStation.AddRange(entity);
            DBContext.SaveChanges();
        }
        public void Update(ExStation entity)
        {
            DBContext.ExStation.Attach(entity);
            DBContext.Entry(entity).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(ExStation entity)
        {
            DBContext.ExStation.Attach(entity);
            var entry = DBContext.Entry(entity);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

    }
}