using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleSeatFabricRepository
    {


        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleSeatFabricRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataVehicleSeatFabric> VehicleSeatFabricList()
        {

            var vehicleSeatFabricQuery = from vehicleSeatFabric in DBContext.VehicleSeatFabric
                                         select vehicleSeatFabric;

            List<MasterDataVehicleSeatFabric> vehicleSeatFabricList = vehicleSeatFabricQuery.ToList();

            return vehicleSeatFabricList;
        }



        public void AddVehicleSeatFabric(MasterDataVehicleSeatFabric vehicleSeatFabric)
        {
            DBContext.VehicleSeatFabric.Add(vehicleSeatFabric);
            DBContext.SaveChanges();
        }





        public void UpdateVehicleSeatFabric(MasterDataVehicleSeatFabric vehicleSeatFabric)
        {
            DBContext.VehicleSeatFabric.Attach(vehicleSeatFabric);
            var entry = DBContext.Entry(vehicleSeatFabric);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

        public void DeleteVehicleSeatFabric(MasterDataVehicleSeatFabric vehicleSeatFabric)
        {
            DBContext.VehicleSeatFabric.Attach(vehicleSeatFabric);
            var entry = DBContext.Entry(vehicleSeatFabric);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

        public List<MasterDataVehicleSeatFabric> FindVehicleSeatFabricByVehicleId(decimal vehicleId)
        {

            var vehicleSeatFabricQuery = from vehicleSeatFabric in DBContext.VehicleSeatFabric
                               where Decimal.Compare(vehicleSeatFabric.VehicleId, vehicleId) == 0

                               select vehicleSeatFabric;


            List<MasterDataVehicleSeatFabric> vehicleSeatFabricList = vehicleSeatFabricQuery.ToList();

            return vehicleSeatFabricList;
        }

    }
}
