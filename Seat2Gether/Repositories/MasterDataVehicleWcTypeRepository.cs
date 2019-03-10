using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleWcTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleWcTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataVehicleWcType> VehicleWcTypeList()
        {

            var vehicleWcTypeQuery = from vehicleWcType in DBContext.VehicleWcType
                                     select vehicleWcType;

            List<MasterDataVehicleWcType> vehicleWcTypeList = vehicleWcTypeQuery.ToList();

            return vehicleWcTypeList;
        }



        public void AddVehicleWcType(MasterDataVehicleWcType vehicleWcType)
        {
            DBContext.VehicleWcType.Add(vehicleWcType);
            DBContext.SaveChanges();
        }





        public void UpdateVehicleWcType(MasterDataVehicleWcType vehicleWcType)
        {
            DBContext.VehicleWcType.Attach(vehicleWcType);
            var entry = DBContext.Entry(vehicleWcType);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

        public void DeleteVehicleWcType(MasterDataVehicleWcType vehicleWcType)
        {
            DBContext.VehicleWcType.Attach(vehicleWcType);
            var entry = DBContext.Entry(vehicleWcType);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

       
    }
}