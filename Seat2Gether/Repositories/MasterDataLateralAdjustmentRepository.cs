using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataLateralAdjustmentRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataLateralAdjustmentRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataLateralAdjustment> LateralAdjustmentList()
        {
            var lateralAdjustmentQuery = from lateralAdjustment in DBContext.LateralAdjustment
                                         select lateralAdjustment;
            List<MasterDataLateralAdjustment> lateralAdjustmentList = lateralAdjustmentQuery.ToList();
            return lateralAdjustmentList;
        }

        public void AddLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            DBContext.LateralAdjustment.Add(lateralAdjustment);
            DBContext.SaveChanges();
        }

        public void UpdateLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            DBContext.LateralAdjustment.Attach(lateralAdjustment);
            var entry = DBContext.Entry(lateralAdjustment);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteLateralAdjustment(MasterDataLateralAdjustment lateralAdjustment)
        {
            DBContext.LateralAdjustment.Attach(lateralAdjustment);
            var entry = DBContext.Entry(lateralAdjustment);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}