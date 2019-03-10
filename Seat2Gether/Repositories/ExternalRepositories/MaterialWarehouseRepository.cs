using Seat2Gether.Models.ExternalModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories.ExternalRepositories
{
    public class MaterialWarehouseRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public MaterialWarehouseRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public IQueryable<ExMaterialWarehouse> GetList()
        {
            return DBContext.ExMaterialWarehouse.AsQueryable();
        }
        public ExMaterialWarehouse Find(object Id)
        {
            return DBContext.ExMaterialWarehouse.Find(Id);
        }
        public void Add(ExMaterialWarehouse entity)
        {
            DBContext.ExMaterialWarehouse.Add(entity);
            DBContext.SaveChanges();
        }
        public void AddRange(IEnumerable<ExMaterialWarehouse> entity)
        {
            DBContext.ExMaterialWarehouse.AddRange(entity);
            DBContext.SaveChanges();
        }
        public void Update(ExMaterialWarehouse entity)
        {
            DBContext.ExMaterialWarehouse.Attach(entity);
            DBContext.Entry(entity).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Delete(ExMaterialWarehouse entity)
        {
            DBContext.ExMaterialWarehouse.Attach(entity);
            var entry = DBContext.Entry(entity);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

    }
}