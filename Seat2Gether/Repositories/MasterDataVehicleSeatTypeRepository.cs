using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleSeatTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleSeatTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleSeatType> VehicleSeatTypeFindList()
        {
            var vehicleSeatTypeQuery = from vehicleSeatType in DBContext.VehicleSeatType
                                    select vehicleSeatType;

            List<MasterDataVehicleSeatType> vehicleSeatTypeList = vehicleSeatTypeQuery.ToList();
            return vehicleSeatTypeList;
        }

        public void AddVehicleSeatType(MasterDataVehicleSeatType vehicleSeatType)
        {
            DBContext.VehicleSeatType.Add(vehicleSeatType);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleSeatType(MasterDataVehicleSeatType vehicleSeatType)
        {
            DBContext.VehicleSeatType.Attach(vehicleSeatType);
            var entry = DBContext.Entry(vehicleSeatType);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteVehicleSeatType(MasterDataVehicleSeatType vehicleSeatType)
        {
            DBContext.VehicleSeatType.Attach(vehicleSeatType);
            var entry = DBContext.Entry(vehicleSeatType);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}