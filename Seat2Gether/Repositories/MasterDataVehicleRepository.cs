using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleRepository
    {
        
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataVehicle> VehicleList()
        {

            var vehicleQuery = from vehicle in DBContext.MasterDataVehicle
                                select vehicle;

            List<MasterDataVehicle> vehicleList = vehicleQuery.ToList();

            return vehicleList;
        }



        public void AddVehicle(MasterDataVehicle vehicle)
        {
            DBContext.MasterDataVehicle.Add(vehicle);
            DBContext.SaveChanges();
        }





        public void UpdateVehicle(MasterDataVehicle vehicle)
        {
            DBContext.MasterDataVehicle.Attach(vehicle);
            var entry = DBContext.Entry(vehicle);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

        public void DeleteVehicle(MasterDataVehicle vehicle)
        {
            DBContext.MasterDataVehicle.Attach(vehicle);
            var entry = DBContext.Entry(vehicle);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

        public List<MasterDataVehicle> FindVehicleByBody(MasterDataVehicle masterDataVehicle)
        {

            var vehicleQuery = from vehicle in DBContext.MasterDataVehicle
                               where vehicle.BBNumber.Contains(masterDataVehicle.BBNumber)
                               && vehicle.Country.Contains(masterDataVehicle.Country)
                               &&  (Decimal.Compare(vehicle.ModelId, masterDataVehicle.ModelId) == 0 || Decimal.Compare(masterDataVehicle.ModelId, new Decimal(0)) == 0)
                               && (Decimal.Compare(vehicle.TypeId, masterDataVehicle.TypeId) == 0 || Decimal.Compare(masterDataVehicle.TypeId, new Decimal(0)) == 0)
                               orderby masterDataVehicle.BBNumber ascending
                               select vehicle;

            List<MasterDataVehicle> vehicleList = vehicleQuery.ToList();

            return vehicleList;
        }

        public List<MasterDataVehicle> FindVehicleByID(decimal vehicleID)
        {

            var vehicleQuery = from vehicle in DBContext.MasterDataVehicle
                               where Decimal.Compare(vehicle.ID, vehicleID) == 0
                              
                               select vehicle;


            List<MasterDataVehicle> vehicleList = vehicleQuery.ToList();

            return vehicleList;
        }

    }
}
