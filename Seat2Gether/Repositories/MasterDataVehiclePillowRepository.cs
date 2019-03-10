using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehiclePillowRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public MasterDataVehiclePillowRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehiclePillow> VehiclePillowList()
        {
            var vehiclePillowQuery = from vehiclePillow in DBContext.VehiclePillow
                                 select vehiclePillow;

            List<MasterDataVehiclePillow> VehiclePillow = vehiclePillowQuery.ToList();
            return VehiclePillow;
        }

        public void AddVehiclePillow(MasterDataVehiclePillow vehiclePillow)
        {
            DBContext.VehiclePillow.Add(vehiclePillow);
            DBContext.SaveChanges();
        }

        public void UpdateVehiclePillow(MasterDataVehiclePillow vehiclePillow)
        {
            DBContext.VehiclePillow.Attach(vehiclePillow);
            var entity = DBContext.Entry(vehiclePillow);
            entity.State = EntityState.Modified;
            DBContext.SaveChanges();   
        }

        public void DeleteVehiclePillow(MasterDataVehiclePillow vehiclePillow)
        {
            DBContext.VehiclePillow.Attach(vehiclePillow);
            var entity = DBContext.Entry(vehiclePillow);
            entity.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}