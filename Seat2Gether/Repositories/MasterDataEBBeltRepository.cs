using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataEBBeltRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataEBBeltRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataEBBelt> EBBelteList()
        {
            var eBBeltQuery = from eBBelt in DBContext.EBBelt
                                 select eBBelt;
            List<MasterDataEBBelt> eBBeltList = eBBeltQuery.ToList();
            return eBBeltList;
        }

        public void AddEBBelt(MasterDataEBBelt eBBelt)
        {
            DBContext.EBBelt.Add(eBBelt);
            DBContext.SaveChanges();
        }

        public void UpdateEBBelt(MasterDataEBBelt eBBelt)
        {
            DBContext.EBBelt.Attach(eBBelt);
            var entry = DBContext.Entry(eBBelt);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteEBBelt(MasterDataEBBelt eBBelt)
        {
            DBContext.EBBelt.Attach(eBBelt);
            var entry = DBContext.Entry(eBBelt);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}