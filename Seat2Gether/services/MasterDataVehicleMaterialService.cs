using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    
        public class MasterDataVehicleMaterialService
    {
            private MasterDataVehicleMaterialRepository vehicleMaterialRepository = null;

            public MasterDataVehicleMaterialService()
            {
            vehicleMaterialRepository = new MasterDataVehicleMaterialRepository();
            }

            public List<MasterDataVehicleMaterialDto> VehicleMaterialList()
            {

                List<MasterDataVehicleMaterialDto> vehicleMaterialDtoList = new List<MasterDataVehicleMaterialDto>();
                List<MasterDataVehicleMaterial> vehicleMaterialList = new List<MasterDataVehicleMaterial>();
            vehicleMaterialList = vehicleMaterialRepository.VehicleMaterialList();

            vehicleMaterialDtoList = vehicleMaterialList.CreateMappedList<MasterDataVehicleMaterial, MasterDataVehicleMaterialDto>();

                return vehicleMaterialDtoList;
            }



        public void AddVehicleMaterial(MasterDataVehicleMaterialDto vehicleMaterial)
        {

            MasterDataVehicleMaterial VehicleMaterialList = vehicleMaterial.CreateMapped<MasterDataVehicleMaterialDto, MasterDataVehicleMaterial>();
            vehicleMaterialRepository.AddVehicleMaterial(VehicleMaterialList);
        }


        public void UpdateVehicleMaterial(MasterDataVehicleMaterialDto vehicleMaterial)
        {
            MasterDataVehicleMaterial VehicleMaterialList = vehicleMaterial.CreateMapped<MasterDataVehicleMaterialDto, MasterDataVehicleMaterial>();
            vehicleMaterialRepository.UpdateVehicleMaterial(VehicleMaterialList);

        }


        public void DeleteVehicleMaterial(MasterDataVehicleMaterialDto vehicleMaterial)
        {
            MasterDataVehicleMaterial VehicleMaterialList = vehicleMaterial.CreateMapped<MasterDataVehicleMaterialDto, MasterDataVehicleMaterial>();
            vehicleMaterialRepository.DeleteVehicleMaterial(VehicleMaterialList);
        }
    }
}
