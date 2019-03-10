using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleSeatHeaderFastenerTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleSeatHeaderFastenerTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleSeatHeaderFastenerType> VehicleSeatHeaderFastenerList()
        {
            var vehicleSeatHeaderFastenerTypeQuery = from vehicleSeatHeaderFastenerType in DBContext.VehicleSeatHeaderFastenerType
                                                     select vehicleSeatHeaderFastenerType;
            List<MasterDataVehicleSeatHeaderFastenerType> vehicleSeatHeaderFastenerTypeList = vehicleSeatHeaderFastenerTypeQuery.ToList();
            return vehicleSeatHeaderFastenerTypeList;

        }

        public void AddVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerType vehicleSeatHeaderFastenerType)
        {
            DBContext.VehicleSeatHeaderFastenerType.Add(vehicleSeatHeaderFastenerType);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerType vehicleSeatHeaderFastenerType)
        {
            DBContext.VehicleSeatHeaderFastenerType.Attach(vehicleSeatHeaderFastenerType);
            var entry = DBContext.Entry(vehicleSeatHeaderFastenerType);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteVehicleSeatHeaderFastenerType(MasterDataVehicleSeatHeaderFastenerType vehicleSeatHeaderFastenerType)
        {
            DBContext.VehicleSeatHeaderFastenerType.Attach(vehicleSeatHeaderFastenerType);
            var entry = DBContext.Entry(vehicleSeatHeaderFastenerType);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

    }
}