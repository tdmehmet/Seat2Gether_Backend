using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleHolderAssemblyTypeService
    {
        private MasterDataVehicleHolderAssemblyTypeRepository MasterDataVehicleHolderAssemblyTypeRepository = null;

        public MasterDataVehicleHolderAssemblyTypeService()
        {
            MasterDataVehicleHolderAssemblyTypeRepository = new MasterDataVehicleHolderAssemblyTypeRepository();
        }

        public List<MasterDataVehicleHolderAssemblyTypeDto> VehicleHolderAssemblyTypeList()
        {
            List<MasterDataVehicleHolderAssemblyType> vehicleHolderAssemblyTypeList = new List<MasterDataVehicleHolderAssemblyType>();
            List<MasterDataVehicleHolderAssemblyTypeDto> vehicleHolderAssemblyTypeListDto = new List<MasterDataVehicleHolderAssemblyTypeDto>();
            vehicleHolderAssemblyTypeList = MasterDataVehicleHolderAssemblyTypeRepository.VehicleHolderAssemblyTypeList();
            vehicleHolderAssemblyTypeListDto = vehicleHolderAssemblyTypeList.CreateMappedList<MasterDataVehicleHolderAssemblyType, MasterDataVehicleHolderAssemblyTypeDto>();
            return vehicleHolderAssemblyTypeListDto;
        }

        public void AddVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyTypeDto vehicleHolderAssemblyType)
        {
            MasterDataVehicleHolderAssemblyType vehicleHolderAssemblyTYPE = vehicleHolderAssemblyType.CreateMapped<MasterDataVehicleHolderAssemblyTypeDto, MasterDataVehicleHolderAssemblyType>();
            MasterDataVehicleHolderAssemblyTypeRepository.AddVehicleHolderAssemblyType(vehicleHolderAssemblyTYPE);
        }

        public void UpdateVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyTypeDto vehicleHolderAssemblyType)
        {
            MasterDataVehicleHolderAssemblyType vehicleHolderAssemblyTYPE = vehicleHolderAssemblyType.CreateMapped<MasterDataVehicleHolderAssemblyTypeDto, MasterDataVehicleHolderAssemblyType>();
            MasterDataVehicleHolderAssemblyTypeRepository.UpdateVehicleHolderAssemblyType(vehicleHolderAssemblyTYPE);
        }

        public void DeleteVehicleHolderAssemblyType(MasterDataVehicleHolderAssemblyTypeDto vehicleHolderAssemblyType)
        {
            MasterDataVehicleHolderAssemblyType vehicleHolderAssemblyTYPE = vehicleHolderAssemblyType.CreateMapped<MasterDataVehicleHolderAssemblyTypeDto, MasterDataVehicleHolderAssemblyType>();
            MasterDataVehicleHolderAssemblyTypeRepository.DeleteVehicleHolderAssemblyType(vehicleHolderAssemblyTYPE);

        }
    }
}