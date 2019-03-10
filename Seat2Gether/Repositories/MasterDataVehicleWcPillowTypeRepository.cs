using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleWcPillowTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleWcPillowTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleWcPillowType> VehicleWcPillowTypeList()
        {
            var vehicleWcPillowTypeQuery = from vehicleWcPillowType in DBContext.VehicleWcPillowType
                                           select vehicleWcPillowType;

            List<MasterDataVehicleWcPillowType> vehicleWcPillowTypeList = vehicleWcPillowTypeQuery.ToList();
            return vehicleWcPillowTypeList;
        }

        public void AddVehicleWcPillowType(MasterDataVehicleWcPillowType vehicleWcPillowType)
        {
            DBContext.VehicleWcPillowType.Add(vehicleWcPillowType);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleWcPillowType(MasterDataVehicleWcPillowType vehicleWcPillowType)
        {
            DBContext.VehicleWcPillowType.Attach(vehicleWcPillowType);
            var entity = DBContext.Entry(vehicleWcPillowType);
            entity.State = EntityState.Modified;
            DBContext.SaveChanges();

        }


        public void DeleteVehicleWcPillowType(MasterDataVehicleWcPillowType vehicleWcPillowType)
        {
            DBContext.VehicleWcPillowType.Attach(vehicleWcPillowType);
            var entity = DBContext.Entry(vehicleWcPillowType);
            entity.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}