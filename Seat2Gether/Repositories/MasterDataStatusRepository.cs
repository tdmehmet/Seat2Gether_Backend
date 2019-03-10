using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataStatusRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataStatusRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataStatus> StatusList()
        {

            var statusQuery = from status in DBContext.Status
                              orderby status.LfdnrStatus descending
                              select status;

            List<MasterDataStatus> statusList = statusQuery.ToList();

            return statusList;
        }



        public void AddStatus(MasterDataStatus status)
        {
            DBContext.Status.Add(status);
            DBContext.SaveChanges();
        }


        public void DeleteStatus(MasterDataStatus status)
        {
            DBContext.Status.Attach(status);
            var entry = DBContext.Entry(status);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }


        public void UpdateStatus(MasterDataStatus status)
        {
            DBContext.Status.Attach(status);
            var entry = DBContext.Entry(status);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

    }
}