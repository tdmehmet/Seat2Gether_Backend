using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleBackRowPillowRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public MasterDataVehicleBackRowPillowRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleBackRowPillow> VehicleBackRowPillowList()
        {
            var VehicleBackRowPillowQuery = from vehicleBackRowPillow in DBContext.VehicleBackRowPillow
                                            select vehicleBackRowPillow;

            List<MasterDataVehicleBackRowPillow> VehicleBackRowPillowList = VehicleBackRowPillowQuery.ToList();
            return VehicleBackRowPillowList;
        }

        public void AddVehicleBackRowPillow(MasterDataVehicleBackRowPillow vehicleBackRowPillow)
        {
            DBContext.VehicleBackRowPillow.Add(vehicleBackRowPillow);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleBackRowPillow(MasterDataVehicleBackRowPillow vehicleBackRowPillow)
        {
            DBContext.VehicleBackRowPillow.Attach(vehicleBackRowPillow);
            var entity = DBContext.Entry(vehicleBackRowPillow);
            entity.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteVehicleBackRowPillow(MasterDataVehicleBackRowPillow vehicleBackRowPillow)
        {
            DBContext.VehicleBackRowPillow.Attach(vehicleBackRowPillow);
            var entity = DBContext.Entry(vehicleBackRowPillow);
            entity.State = EntityState.Deleted;
            DBContext.SaveChanges();

        }
    }
}