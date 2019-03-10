using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataRearSeatPanRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataRearSeatPanRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataRearSeatPan> RearSeatPanList()
        {
            var rearSeatPanQuery = from rearSeatPan in DBContext.RearSeatPan
                                   select rearSeatPan;
            List<MasterDataRearSeatPan> rearSeatPanList = rearSeatPanQuery.ToList();
            return rearSeatPanList;
        }

        public void AddRearSeatPan(MasterDataRearSeatPan rearSeatPan)
        {
            DBContext.RearSeatPan.Add(rearSeatPan);
            DBContext.SaveChanges();
        }

        public void UpdateRearSeatPan(MasterDataRearSeatPan rearSeatPan)
        {
            DBContext.RearSeatPan.Attach(rearSeatPan);
            var entry = DBContext.Entry(rearSeatPan);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteRearSeatPan(MasterDataRearSeatPan rearSeatPan)
        {
            DBContext.RearSeatPan.Attach(rearSeatPan);
            var entry = DBContext.Entry(rearSeatPan);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}