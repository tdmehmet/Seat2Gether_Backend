using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleModelRepository
    {
        private Seat2GetherDBContext DBContext;
        
        public MasterDataVehicleModelRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleModel> VehicleModelFindList()
        {
            var vehicleModelQuery = from vehicleModel in DBContext.VehicleModel
                               select vehicleModel;

            List<MasterDataVehicleModel> vehicleModelList = vehicleModelQuery.ToList();
            return vehicleModelList;
        }

        public void AddVehicleModel(MasterDataVehicleModel vehicleModel)
        {
            DBContext.VehicleModel.Add(vehicleModel);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleModel (MasterDataVehicleModel vehicleModel)
        {
            DBContext.VehicleModel.Attach(vehicleModel);
            var entry = DBContext.Entry(vehicleModel);
            entry.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteVehicleModel(MasterDataVehicleModel vehicleModel)
        {
            DBContext.VehicleModel.Attach(vehicleModel);
            var entry = DBContext.Entry(vehicleModel);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}