using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataSTMaterialMasterRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataSTMaterialMasterRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataSTMaterialMaster> STMaterialMasterList()
        {
            var sTMaterialMasterQuery = from sTMaterialMaster in DBContext.STMaterialMaster
                                        select sTMaterialMaster;
            List<MasterDataSTMaterialMaster> sTMaterialMasterList = sTMaterialMasterQuery.ToList();
            return sTMaterialMasterList;
        }

        public void AddSTMaterialMaster(MasterDataSTMaterialMaster sTMaterialMaster)
        {
            DBContext.STMaterialMaster.Add(sTMaterialMaster);
            DBContext.SaveChanges();
        }

        public void UpdateSTMaterialMaster(MasterDataSTMaterialMaster sTMaterialMaster)
        {
            DBContext.STMaterialMaster.Attach(sTMaterialMaster);
            var entry = DBContext.Entry(sTMaterialMaster);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteSTMaterialMaster(MasterDataSTMaterialMaster sTMaterialMaster)
        {
            DBContext.STMaterialMaster.Attach(sTMaterialMaster);
            var entry = DBContext.Entry(sTMaterialMaster);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}