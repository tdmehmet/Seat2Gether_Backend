using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleWcTypeService
    {
        private MasterDataVehicleWcTypeRepository MasterDataVehicleWcTypeRepository = null;
        public MasterDataVehicleWcTypeService()
        {
            MasterDataVehicleWcTypeRepository = new MasterDataVehicleWcTypeRepository();
        }

        public List<MasterDataVehicleWcTypeDto>VehicleWcTypeList()
        {
            List<MasterDataVehicleWcType> vehicleWcTypeList = new List<MasterDataVehicleWcType>();
            List<MasterDataVehicleWcTypeDto> vehicleWcTypeDtoList = new List<MasterDataVehicleWcTypeDto>();

            vehicleWcTypeList = MasterDataVehicleWcTypeRepository.VehicleWcTypeList();
            vehicleWcTypeDtoList = vehicleWcTypeList.CreateMappedList<MasterDataVehicleWcType, MasterDataVehicleWcTypeDto>();

            return vehicleWcTypeDtoList;
        }

        public void AddVehicleWcType(MasterDataVehicleWcTypeDto vehicleWCType)
        {
            MasterDataVehicleWcType vehicleWcType = vehicleWCType.CreateMapped<MasterDataVehicleWcTypeDto, MasterDataVehicleWcType>();
            MasterDataVehicleWcTypeRepository.AddVehicleWcType(vehicleWcType);

        }

        public void UpdateVehicleWcType(MasterDataVehicleWcTypeDto vehicleWCType)
        {
            MasterDataVehicleWcType vehicleWcType = vehicleWCType.CreateMapped<MasterDataVehicleWcTypeDto, MasterDataVehicleWcType>();
            MasterDataVehicleWcTypeRepository.UpdateVehicleWcType(vehicleWcType);

        }

        public void DeleteVehicleWcType(MasterDataVehicleWcTypeDto vehicleWCType)
        {
            MasterDataVehicleWcType vehicleWcType = vehicleWCType.CreateMapped<MasterDataVehicleWcTypeDto, MasterDataVehicleWcType>();
            MasterDataVehicleWcTypeRepository.DeleteVehicleWcType(vehicleWcType);

        }
    }
}

