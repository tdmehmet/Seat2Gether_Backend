using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataMaterialMasterRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataMaterialMasterRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataMaterialMaster> MaterialMasterList()
        {

            var materialMasterQuery = from materialMaster in DBContext.MaterialMaster
                                      select materialMaster;

            List<MasterDataMaterialMaster> materialMasterList = materialMasterQuery.ToList();

            return materialMasterList;
        }



        public void AddMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            DBContext.MaterialMaster.Add(materialMaster);
            DBContext.SaveChanges();
        }


        public void DeleteMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            DBContext.MaterialMaster.Attach(materialMaster);
            var entry = DBContext.Entry(materialMaster);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }


        public void UpdateMaterialMaster(MasterDataMaterialMaster materialMaster)
        {
            DBContext.MaterialMaster.Attach(materialMaster);
            var entry = DBContext.Entry(materialMaster);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }


    }
}