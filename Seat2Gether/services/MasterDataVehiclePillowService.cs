using Seat2Gether.dto;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seat2Gether.services
{
    public class MasterDataVehiclePillowService
    {
        private MasterDataVehiclePillowRepository MasterDataVehiclePillowRepository = null;

        public MasterDataVehiclePillowService()
        {
            MasterDataVehiclePillowRepository = new MasterDataVehiclePillowRepository();
        }
        
        public List<MasterDataVehiclePillowDto>VehiclePillowList()
        {
            List<MasterDataVehiclePillow> vehiclePillowList = new List<MasterDataVehiclePillow>();
            List<MasterDataVehiclePillowDto> vehiclePillowDtoList = new List<MasterDataVehiclePillowDto>();
            vehiclePillowList=MasterDataVehiclePillowRepository.VehiclePillowList();
            vehiclePillowDtoList = vehiclePillowList.CreateMappedList<MasterDataVehiclePillow, MasterDataVehiclePillowDto>();
            return vehiclePillowDtoList;
        }

        public void AddVehiclePillow(MasterDataVehiclePillowDto vehiclePillow)
        {
            MasterDataVehiclePillow vehiclePillowList = vehiclePillow.CreateMapped<MasterDataVehiclePillowDto, MasterDataVehiclePillow>();
            MasterDataVehiclePillowRepository.AddVehiclePillow(vehiclePillowList);
        }

        public void UpdateVehiclePillow(MasterDataVehiclePillowDto vehiclePillow)
        {
            MasterDataVehiclePillow vehiclePillowList = vehiclePillow.CreateMapped<MasterDataVehiclePillowDto, MasterDataVehiclePillow>();
            MasterDataVehiclePillowRepository.UpdateVehiclePillow(vehiclePillowList);
        }

        public void DeleteVehiclePillow(MasterDataVehiclePillowDto vehiclePillow)
        {
            MasterDataVehiclePillow vehiclePillowList = vehiclePillow.CreateMapped<MasterDataVehiclePillowDto, MasterDataVehiclePillow>();
            MasterDataVehiclePillowRepository.DeleteVehiclePillow(vehiclePillowList);
        }
    }
}