using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataBackrestAdjusterRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataBackrestAdjusterRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataBackrestAdjuster> BackrestAdjusterList()
        {
            var backrestAdjusterQuery = from backrestAdjuster in DBContext.BackrestAdjuster
                                        select backrestAdjuster;
            List<MasterDataBackrestAdjuster> backrestAdjusterList = backrestAdjusterQuery.ToList();
            return backrestAdjusterList;
        }

        public void AddBackrestAdjuster(MasterDataBackrestAdjuster backrestAdjuster)
        {
            DBContext.BackrestAdjuster.Add(backrestAdjuster);
            DBContext.SaveChanges();
        }

        public void UpdateBackrestAdjuster(MasterDataBackrestAdjuster backrestAdjuster)
        {
            DBContext.BackrestAdjuster.Attach(backrestAdjuster);
            var entry = DBContext.Entry(backrestAdjuster);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteBackrestAdjuster(MasterDataBackrestAdjuster backrestAdjuster)
        {
            DBContext.BackrestAdjuster.Attach(backrestAdjuster);
            var entry = DBContext.Entry(backrestAdjuster);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}