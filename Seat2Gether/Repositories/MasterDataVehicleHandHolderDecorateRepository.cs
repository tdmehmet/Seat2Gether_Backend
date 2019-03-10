using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleHandHolderDecorateRepository
    {
        private Seat2GetherDBContext DBContext = null;

        public MasterDataVehicleHandHolderDecorateRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleHandHolderDecorate> VehicleHandHolderDecorateList()
        {
            var VehicleHandHolderDecorateQuery = from vehicleHandHolderDecorate in DBContext.VehicleHandHolderDecorate
                                                 select vehicleHandHolderDecorate;

            List<MasterDataVehicleHandHolderDecorate> VehicleHandHolderDecorateList = VehicleHandHolderDecorateQuery.ToList();
            return VehicleHandHolderDecorateList;
        }

        public void AddVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorate VehicleHandHolderDecorate)
        {
            DBContext.VehicleHandHolderDecorate.Add(VehicleHandHolderDecorate);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorate VehicleHandHolderDecorate)
        {
            DBContext.VehicleHandHolderDecorate.Attach(VehicleHandHolderDecorate);
            var entity = DBContext.Entry(VehicleHandHolderDecorate);
            entity.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteVehicleHandHolderDecorate(MasterDataVehicleHandHolderDecorate VehicleHandHolderDecorate)
        {
            DBContext.VehicleHandHolderDecorate.Attach(VehicleHandHolderDecorate);
            var entity = DBContext.Entry(VehicleHandHolderDecorate);
            entity.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}