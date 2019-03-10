using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories.ExternalRepositories
{
    public class SeatRepository
    {
        private Seat2GetherDBContext DBContext;

        public SeatRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public IQueryable<ExSeatPlacement> GetList()
        {
            return DBContext.ExSeatPlacement.AsQueryable();
        }
        public ExSeatPlacement Find(params object[] keyValue)
        {
            return DBContext.ExSeatPlacement.Find(keyValue);
        }
        public void Add(ExSeatPlacement entity)
        {
            DBContext.ExSeatPlacement.Add(entity);
            DBContext.SaveChanges();
        }
        public void AddRange(IEnumerable<ExSeatPlacement> entity)
        {
            DBContext.ExSeatPlacement.AddRange(entity);
            DBContext.SaveChanges();
        }
        public void Update(ExSeatPlacement entity)
        {
            DBContext.ExSeatPlacement.Attach(entity);
            DBContext.Entry(entity).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(ExSeatPlacement entity)
        {
            DBContext.ExSeatPlacement.Attach(entity);
            var entry = DBContext.Entry(entity);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}