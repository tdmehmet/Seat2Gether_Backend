using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataSideCoverRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataSideCoverRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataSideCover> SideCoverList()
        {
            var sideCoverQuery = from sideCover in DBContext.SideCover
                                 select sideCover;
            List<MasterDataSideCover> sideCoverList = sideCoverQuery.ToList();
            return sideCoverList;
        }

        public MasterDataSideCover FindSideCoverById(string partNumber)
        {
            var sideCoverQuery = from sideCover in DBContext.SideCover
                                where sideCover.PartNumber.Equals(partNumber)
                                select sideCover;
            MasterDataSideCover sideCover_tmp = sideCoverQuery.FirstOrDefault();
            return sideCover_tmp;
        }

        public void AddSideCover(MasterDataSideCover sideCover)
        {
            DBContext.SideCover.Add(sideCover);
            DBContext.SaveChanges();
        }


        public void UpdateSideCover(MasterDataSideCover sideCover)
        {
            MasterDataSideCover x = FindSideCoverById(sideCover.PartNumber);
            x.PartNumber = sideCover.PartNumber;

            DBContext.SideCover.Attach(x);
            var entry = DBContext.Entry(x);
            entry.State = EntityState.Unchanged;
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
            entry.State = EntityState.Unchanged;
        }

        public void DeleteSideCover(MasterDataSideCover sideCover)
        {
            DBContext.SideCover.Attach(sideCover);
            var entry = DBContext.Entry(sideCover);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}