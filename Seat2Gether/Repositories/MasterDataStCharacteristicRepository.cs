using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataStCharacteristicRepository
    {
        private Seat2GetherDBContext DBContext;
        public MasterDataStCharacteristicRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataSTCharacteristic> StCharacteristicList()
        {
            var stCharacteristicQuery = from stCharacteristic in DBContext.STCharacteristic
                                        select stCharacteristic;
            List<MasterDataSTCharacteristic> stCharacteristicList = stCharacteristicQuery.ToList();
            return stCharacteristicList;
        }

        public void AddStCharacteristic(MasterDataSTCharacteristic stCharacteristic)
        {
            DBContext.STCharacteristic.Add(stCharacteristic);
            DBContext.SaveChanges();
        }


        public void UpdateStCharacteristic(MasterDataSTCharacteristic stCharacteristic)
        {
            DBContext.STCharacteristic.Attach(stCharacteristic);
            var entry = DBContext.Entry(stCharacteristic);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }
        public void DeleteStCharacteristic(MasterDataSTCharacteristic stCharacteristic)
        {
            DBContext.STCharacteristic.Attach(stCharacteristic);
            var entry = DBContext.Entry(stCharacteristic);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }

}