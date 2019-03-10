using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataChairFootRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataChairFootRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataChairFoot> ChairFootList()
        {
            var chairFootQuery = from chairFoot in DBContext.ChairFoot
                                 select chairFoot;
            List<MasterDataChairFoot> chairFootList = chairFootQuery.ToList();
            return chairFootList;
        }


        public MasterDataChairFoot FindChairFootById(string chairFootId)
        {
            var masterDataChairFootQuery = from chairFoot in DBContext.ChairFoot
                                        where chairFoot.PartNumber.Equals(chairFootId)
                                        select chairFoot;
            MasterDataChairFoot chairFootById = masterDataChairFootQuery.FirstOrDefault();
            return chairFootById;
        }

        public void AddChairFoot(MasterDataChairFoot chairFoot)
        {
            DBContext.ChairFoot.Add(chairFoot);
            DBContext.SaveChanges();
        }

        public void UpdateChairFoot(MasterDataChairFoot chairFoot)
        {
            MasterDataChairFoot x = FindChairFootById(chairFoot.PartNumber);
            x.PartNumber = chairFoot.PartNumber;

            DBContext.ChairFoot.Attach(x);
            var entry = DBContext.Entry(x);
            entry.State = EntityState.Unchanged;
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
            entry.State = EntityState.Unchanged;
        }

        public void DeleteChairFoot(MasterDataChairFoot chairFoot)
        {
            DBContext.ChairFoot.Attach(chairFoot);
            var entry = DBContext.Entry(chairFoot);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

       
    }

}