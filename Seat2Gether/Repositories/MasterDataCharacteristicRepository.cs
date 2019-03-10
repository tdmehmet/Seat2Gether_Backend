using Seat2Gether.dto;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataCharacteristicRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataCharacteristicRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataCharacteristic> TMerkmal()
        {

            var characteristicQuery = from TMerkmal in DBContext.Characteristic
                                      orderby TMerkmal.LfdnrCharacteristic descending
                                      select TMerkmal;

            List<MasterDataCharacteristic> allMerkmalView = characteristicQuery.ToList();

            return allMerkmalView;
        }

        public MasterDataCharacteristic FindCharacteristicById(int Id)
        {
            return DBContext.Characteristic.Find(Id);
        }

        private Int32 FindMinAvailableCharacteristicId()
        {
            Int32 maxCharacteristicId = DBContext.Characteristic.Max(characteristic => characteristic.LfdnrCharacteristic);

            return maxCharacteristicId + 1;

        }

        public void AddCharacteristic(MasterDataCharacteristic merkmal)
        {
            merkmal.LfdnrCharacteristic = FindMinAvailableCharacteristicId();

            DBContext.Characteristic.Add(merkmal);
            DBContext.SaveChanges();
        }

       
        public void DeleteCharacteristic(MasterDataCharacteristic merkmal)
        {
            MasterDataCharacteristic tmpMerkmal = FindCharacteristicById(merkmal.LfdnrCharacteristic);
            if (tmpMerkmal != null)
            {
                DBContext.Characteristic.Remove(tmpMerkmal);
                DBContext.SaveChanges();
            }
        }


        public void UpdateCharacteristic(MasterDataCharacteristic merkmal)
        {
            DBContext.Characteristic.Attach(merkmal);
            var entry = DBContext.Entry(merkmal);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

    }
}