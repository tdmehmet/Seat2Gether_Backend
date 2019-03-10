using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories.ExternalRepositories
{
    public class MasterDataSeatTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataSeatTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public IQueryable<ExMasterDataSeatType> GetList()
        {
            return DBContext.ExMasterDataSeatType.AsQueryable();
        }
        public ExMasterDataSeatType Find(params object[] keyValue)
        {
            return DBContext.ExMasterDataSeatType.Find(keyValue);
        }
        public void Add(ExMasterDataSeatType entity)
        {
            DBContext.ExMasterDataSeatType.Add(entity);
            DBContext.SaveChanges();
        }
        public void AddRange(IEnumerable<ExMasterDataSeatType> entity)
        {
            DBContext.ExMasterDataSeatType.AddRange(entity);
            DBContext.SaveChanges();
        }
        public void Update(ExMasterDataSeatType entity)
        {
            DBContext.ExMasterDataSeatType.Attach(entity);
            DBContext.Entry(entity).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(ExMasterDataSeatType entity)
        {
            DBContext.ExMasterDataSeatType.Attach(entity);
            var entry = DBContext.Entry(entity);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}

