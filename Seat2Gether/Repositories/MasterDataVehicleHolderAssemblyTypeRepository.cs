using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    public class MasterDataVehicleHolderAssemblyTypeRepository
    {
        private Seat2GetherDBContext DBContext;

        public MasterDataVehicleHolderAssemblyTypeRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        public List<MasterDataVehicleHolderAssemblyType> VehicleHolderAssemblyTypeList()
        {
            var VehicleHolderAssemblyTypeQuery = from vehicleHolderAssemblyType in DBContext.VehicleHolderAssemblyType
                                                 select vehicleHolderAssemblyType;

            List<MasterDataVehicleHolderAssemblyType> vehicleHolderAssemblyTypeList = VehicleHolderAssemblyTypeQuery.ToList();
            return vehicleHolderAssemblyTypeList;
        }

        public void AddVehicleHolderAssemblyType (MasterDataVehicleHolderAssemblyType vehicleHolderAssemblyType)
        {
            DBContext.VehicleHolderAssemblyType.Add(vehicleHolderAssemblyType);
            DBContext.SaveChanges();
        }

        public void UpdateVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyType vehicleHolderAssemblyType)
        {
            DBContext.VehicleHolderAssemblyType.Attach(vehicleHolderAssemblyType);
            var entity = DBContext.Entry(vehicleHolderAssemblyType);
            entity.State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void DeleteVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyType vehicleHolderAssemblyType)
        {
            DBContext.VehicleHolderAssemblyType.Attach(vehicleHolderAssemblyType);
            var entity = DBContext.Entry(vehicleHolderAssemblyType);
            entity.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }
    }
}