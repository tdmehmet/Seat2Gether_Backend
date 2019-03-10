using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehicleWcPillowTypeService
    {
        private MasterDataVehicleWcPillowTypeRepository MasterDataVehicleWcPillowRepository = null;
        public MasterDataVehicleWcPillowTypeService()
        {
            MasterDataVehicleWcPillowRepository = new MasterDataVehicleWcPillowTypeRepository();
        }

        public List<MasterDataVehicleWcPillowTypeDto> VehicleWcPillowTypeList()
        {
            List<MasterDataVehicleWcPillowType> vehicleWcPillowTypeList = new List<MasterDataVehicleWcPillowType>();
            List<MasterDataVehicleWcPillowTypeDto> vehicleWcPillowTypeDtoList = new List<MasterDataVehicleWcPillowTypeDto>();
            vehicleWcPillowTypeList = MasterDataVehicleWcPillowRepository.VehicleWcPillowTypeList();
            vehicleWcPillowTypeDtoList = vehicleWcPillowTypeList.CreateMappedList<MasterDataVehicleWcPillowType, MasterDataVehicleWcPillowTypeDto>();
            return vehicleWcPillowTypeDtoList;
        }

        public void AddVehicleWcPillowType(MasterDataVehicleWcPillowTypeDto vehicleWCPillowType)
        {
            MasterDataVehicleWcPillowType vehicleWcPillowType = vehicleWCPillowType.CreateMapped<MasterDataVehicleWcPillowTypeDto, MasterDataVehicleWcPillowType>();
            MasterDataVehicleWcPillowRepository.AddVehicleWcPillowType(vehicleWcPillowType);
        }

        public void UpdateVehicleWcPillowType(MasterDataVehicleWcPillowTypeDto vehicleWCPillowType)
        {
            MasterDataVehicleWcPillowType vehicleWcPillowType = vehicleWCPillowType.CreateMapped<MasterDataVehicleWcPillowTypeDto, MasterDataVehicleWcPillowType>();
            MasterDataVehicleWcPillowRepository.UpdateVehicleWcPillowType(vehicleWcPillowType);
        }

        public void DeleteVehicleWcPillowType(MasterDataVehicleWcPillowTypeDto vehicleWCPillowType)
        {
            MasterDataVehicleWcPillowType vehicleWcPillowType = vehicleWCPillowType.CreateMapped<MasterDataVehicleWcPillowTypeDto, MasterDataVehicleWcPillowType>();
            MasterDataVehicleWcPillowRepository.DeleteVehicleWcPillowType(vehicleWcPillowType);
        }
    }
}