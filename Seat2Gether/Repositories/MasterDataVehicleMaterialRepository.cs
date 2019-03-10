using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seat2Gether.Repositories
{
    
        public class MasterDataVehicleMaterialRepository
        {

            private Seat2GetherDBContext DBContext;

            public MasterDataVehicleMaterialRepository()
            {
                DBContext = new Seat2GetherDBContext();
            }


            public List<MasterDataVehicleMaterial> VehicleMaterialList()
            {

                var vehicleMaterialQuery = from vehicleMaterial in DBContext.VehicleMaterial
                                           select vehicleMaterial;

                List<MasterDataVehicleMaterial> vehicleMaterialList = vehicleMaterialQuery.ToList();

                return vehicleMaterialList;
            }



        public void AddVehicleMaterial(MasterDataVehicleMaterial vehicleMaterial)
        {
            DBContext.VehicleMaterial.Add(vehicleMaterial);
            DBContext.SaveChanges();
        }





        public void UpdateVehicleMaterial(MasterDataVehicleMaterial vehicleMaterial)
        {
            DBContext.VehicleMaterial.Attach(vehicleMaterial);
            var entry = DBContext.Entry(vehicleMaterial);
            entry.State = EntityState.Modified;

            DBContext.SaveChanges();
        }

        public void DeleteVehicleMaterial(MasterDataVehicleMaterial vehicleMaterial)
        {
            DBContext.VehicleMaterial.Attach(vehicleMaterial);
            var entry = DBContext.Entry(vehicleMaterial);
            entry.State = EntityState.Deleted;
            DBContext.SaveChanges();
        }

    }
    }