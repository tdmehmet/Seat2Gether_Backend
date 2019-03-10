using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataWallConnectionRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataWallConnectionRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataWallConnection> WallConnectionList()
        {
            var wallConnectionQuery = from wallConnection in DBContext.WallConnection
                                      select wallConnection;
            List<MasterDataWallConnection> wallConnectionList = wallConnectionQuery.ToList();
            return wallConnectionList;
        }

        public void AddWallConnection(MasterDataWallConnection wallConnection)
        {
            DBContext.WallConnection.Add(wallConnection);
            DBContext.SaveChanges();
        }

      

        public void DeleteWallConnection(MasterDataWallConnection wallConnection)
        {
            DBContext.WallConnection.Attach(wallConnection);
            var entry = DBContext.Entry(wallConnection);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}