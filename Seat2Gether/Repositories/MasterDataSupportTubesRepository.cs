using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataSupportTubesRepository
    {
        private Seat2GetherDBContext DBContext = null;
        public MasterDataSupportTubesRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataSupportTubes> SupportTubesList()
        {
            var supportTubesQuery = from supportTubes in DBContext.SupportTubes
                                    select supportTubes;

            List<MasterDataSupportTubes> supportTubesList = supportTubesQuery.ToList();
            return supportTubesList;
        }

        public void AddSupportTubes(MasterDataSupportTubes supportTubes)
        {
            DBContext.SupportTubes.Add(supportTubes);
            DBContext.SaveChanges();
        }

        public void UpdateSupportTubes(MasterDataSupportTubes supportTubes)
        {
            DBContext.SupportTubes.Attach(supportTubes);
            var entry = DBContext.Entry(supportTubes);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteSupportTubes(MasterDataSupportTubes supportTubes)
        {
            DBContext.SupportTubes.Attach(supportTubes);
            var entry = DBContext.Entry(supportTubes);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}