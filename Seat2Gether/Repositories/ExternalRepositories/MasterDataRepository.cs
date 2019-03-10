using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories.ExternalRepositories
{
    public class MasterDataRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public IQueryable<ExMasterData> GetList()
        {
            return DBContext.ExMasterData.AsQueryable();
        }
        public ExMasterData Find(params object[] keyValue)
        {
            return DBContext.ExMasterData.Find(keyValue);
        }
        public void Add(ExMasterData entity)
        {
            DBContext.ExMasterData.Add(entity);
            DBContext.SaveChanges();
        }
        public void AddRange(IEnumerable<ExMasterData> entity)
        {
            DBContext.ExMasterData.AddRange(entity);
            DBContext.SaveChanges();
        }
        public void Update(ExMasterData entity)
        {
            DBContext.ExMasterData.Attach(entity);
            DBContext.Entry(entity).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(ExMasterData entity)
        {
            DBContext.ExMasterData.Attach(entity);
            var entry = DBContext.Entry(entity);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}

