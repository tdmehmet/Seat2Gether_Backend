using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{

    public class MasterDataVehicleMainInfoRepository
    {

        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleMainInfoRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }


        public List<MasterDataVehicleSeatMainInfo> VehicleMainInfoList()
        {

            var vehicleMainInfoServiceQuery = from vehicleMainInfoService in DBContext.VehicleSeatMainInfo
                                              select vehicleMainInfoService;

            List<MasterDataVehicleSeatMainInfo> vehicleMainInfoServiceList = vehicleMainInfoServiceQuery.ToList();

            return vehicleMainInfoServiceList;
        }



        public void AddVehicleSeatMainInfo(MasterDataVehicleSeatMainInfo vehicleMainInfoService)
        {
            DBContext.VehicleSeatMainInfo.Add(vehicleMainInfoService);
            DBContext.SaveChanges();
        }





        public void UpdateVehicleSeatMainInfo(MasterDataVehicleSeatMainInfo vehicleMainInfoService)
        {
            DBContext.VehicleSeatMainInfo.Attach(vehicleMainInfoService);
            var entry = DBContext.Entry(vehicleMainInfoService);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

        public void DeleteVehicleSeatMainInfo(MasterDataVehicleSeatMainInfo vehicleMainInfoService)
        {
            DBContext.VehicleSeatMainInfo.Attach(vehicleMainInfoService);
            var entry = DBContext.Entry(vehicleMainInfoService);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

        public List<MasterDataVehicleSeatMainInfo> FindVehicleSeatMainByVehicleId(decimal vehicleId)
        {

            var vehicleSeatMainInfoQuery = from vehicleSeatMainInfo in DBContext.VehicleSeatMainInfo
                                         where Decimal.Compare(vehicleSeatMainInfo.VehicleId, vehicleId) == 0

                                         select vehicleSeatMainInfo;


            List<MasterDataVehicleSeatMainInfo> vehicleSeatMainInfoList = vehicleSeatMainInfoQuery.ToList();

            return vehicleSeatMainInfoList;
        }


    }
}